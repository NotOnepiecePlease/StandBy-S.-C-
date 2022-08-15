using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using PFC___StandBy_CSharp.APIs.License.Json;

namespace PFC___StandBy_CSharp.APIs.License
{
    public partial class Api
    {
        public string name, ownerid, secret, version;
        private string sessionid, enckey;
        private bool initzalized;

        public ResponseClass response = new ResponseClass();
        public AppDataClass app_data = new AppDataClass();
        public UserDataClass user_data = new UserDataClass();
        private readonly JsonWrapper response_decoder = new JsonWrapper(new ResponseStructure());

        // Set up your application credentials in order to use keyauth
        /// <param name="name">Application Name</param>
        /// <param name="ownerid">Your OwnerID, can be found in your account settings.</param>
        /// <param name="secret">Application Secret</param>
        /// <param name="version">Application Version, if version doesnt match it will open the download link you set up in your application settings and close the app, if empty the app will close</param>
        public Api(string name, string ownerid, string secret, string version)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
            {
                GenerateError("Application not setup correctly. Please watch video link found in Program.cs");
                Environment.Exit(0);
            }

            this.name = name;
            this.ownerid = ownerid;
            this.secret = secret;
            this.version = version;
        }

        // Initializes the connection with keyauth in order to use any of the functions
        public void InitializeConnectionKeyAuth()
        {
            enckey = Encryption.sha256(Encryption.iv_key());
            var init_iv = Encryption.sha256(Encryption.iv_key());
            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("init")),
                ["ver"] = Encryption.Encrypt(version, secret, init_iv),
                ["hash"] = GenerateChecksum(Process.GetCurrentProcess().MainModule?.FileName),
                ["enckey"] = Encryption.Encrypt(enckey, secret, init_iv),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            if (responseRequest == "KeyAuth_Invalid")
            {
                GenerateError("Application not found");
                Environment.Exit(0);
            }

            responseRequest = Encryption.Decrypt(responseRequest, secret, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
            {
                LoadAppData(json.appinfo);
                sessionid = json.sessionid;
                initzalized = true;
            }
            else if (json.message == "invalidver")
            {
                app_data.downloadLink = json.download;
            }
        }

        #region Checkinit

        public static bool IsDebugRelease
        {
            get
            {
#if DEBUG
                return true;
#else
            return false;
#endif
            }
        }

        public void Checkinit()
        {
            if (!initzalized)
            {
                GenerateError(IsDebugRelease
                    ? "Not initialized Check if KeyAuthApp.init() does exist"
                    : "Please initialize first");
            }
        }

        #endregion Checkinit

        // Registers the user using a license and gives the user a subscription that matches their license level
        /// <param name="username">Username</param>
        /// <param name="pass">Password</param>
        /// <param name="key">License</param>
        public void RegisterUserWithLicense(string username, string pass, string key)
        {
            Checkinit();

            string hwid = WindowsIdentity.GetCurrent().User?.Value;

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("register")),
                ["username"] = Encryption.Encrypt(username, enckey, init_iv),
                ["pass"] = Encryption.Encrypt(pass, enckey, init_iv),
                ["key"] = Encryption.Encrypt(key, enckey, init_iv),
                ["hwid"] = Encryption.Encrypt(hwid, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                LoadUserData(json.info);
        }

        // Authenticates the user using their username and password
        /// <param name="username">Username</param>
        /// <param name="pass">Password</param>
        public void LoginAuth(string username, string pass)
        {
            Checkinit();

            string hwid = WindowsIdentity.GetCurrent().User?.Value;

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("login")),
                ["username"] = Encryption.Encrypt(username, enckey, init_iv),
                ["pass"] = Encryption.Encrypt(pass, enckey, init_iv),
                ["hwid"] = Encryption.Encrypt(hwid, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                LoadUserData(json.info);
        }

        // Gives the user a subscription that has the same level as the key
        /// <param name="username">Username of the user thats going to get upgraded</param>
        /// <param name="key">License with the same level as the subscription you want to give the user</param>
        public void UpgradeUser(string username, string key)
        {
            Checkinit();

            string hwid = WindowsIdentity.GetCurrent().User?.Value;

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade")),
                ["username"] = Encryption.Encrypt(username, enckey, init_iv),
                ["key"] = Encryption.Encrypt(key, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            json.success = false;
            LoadResponseStruct(json);
        }

        // Authenticate without using usernames and passwords
        /// <param name="key">Licence used to login with</param>
        public void LicenseAuth(string key)
        {
            Checkinit();

            string hwid = WindowsIdentity.GetCurrent().User.Value;

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("license")),
                ["key"] = Encryption.Encrypt(key, enckey, init_iv),
                ["hwid"] = Encryption.Encrypt(hwid, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);

            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                LoadUserData(json.info);
        }

        // checks if the current session is validated or not
        public void CheckSession()
        {
            Checkinit();
            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("check")),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
        }

        // Change the data of an existing user variable, *User must be logged in*
        /// <param name="var">User variable name</param>
        /// <param name="data">The content of the variable</param>
        public void SetVariableData(string var, string data)
        {
            Checkinit();

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar")),
                ["var"] = Encryption.Encrypt(var, enckey, init_iv),
                ["data"] = Encryption.Encrypt(data, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
        }

        // Gets the an existing user variable
        /// <param name="var">User Variable Name</param>
        /// <returns>The content of the user variable</returns>
        public string GetVariableData(string var)
        {
            Checkinit();

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar")),
                ["var"] = Encryption.Encrypt(var, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                return json.response;
            return null;
        }

        // Bans the current logged in user
        public void BanUser()
        {
            Checkinit();

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban")),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
        }

        // Gets an existing global variable
        /// <param name="varid">Variable ID</param>
        /// <returns>The content of the variable</returns>
        public string GetGlobalVariable(string varid)
        {
            Checkinit();

            string hwid = WindowsIdentity.GetCurrent().User.Value;

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("var")),
                ["varid"] = Encryption.Encrypt(varid, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                return json.message;
            return null;
        }

        /// Gets the last 20 sent messages of that channel
        /// <param name="channelname">The channel name</param>
        /// <returns>the last 20 sent messages of that channel</returns>
        public List<Message> GetLastChatMessages(string channelname)
        {
            Checkinit();

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget")),
                ["channel"] = Encryption.Encrypt(channelname, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                return json.messages;
            return null;
        }

        // Sends a message to the given channel name
        /// <param name="msg">Message</param>
        /// <param name="channelname">Channel Name</param>
        /// <returns>If the message was sent successfully, it returns true if not false</returns>
        public bool SendChatMessage(string msg, string channelname)
        {
            Checkinit();

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend")),
                ["message"] = Encryption.Encrypt(msg, enckey, init_iv),
                ["channel"] = Encryption.Encrypt(channelname, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                return true;
            return false;
        }

        /// <summary>
        /// Checks if the current ip address/hwid is blacklisted
        /// </summary>
        /// <returns></returns>
        public bool CheckIfBlacklisted()
        {
            Checkinit();
            string hwid = WindowsIdentity.GetCurrent().User?.Value;

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist")),
                ["hwid"] = Encryption.Encrypt(hwid, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);
            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                return true;
            return false;
        }

        /// Sends a request to a webhook that you've added in the dashboard in a safe way without it being showed for example a http debugger
        /// <param name="webid">Webhook ID</param>
        /// <param name="param">Parameters</param>
        /// <param name="body">Body of the request, empty by default</param>
        /// <param name="conttype">Content type, empty by default</param>
        /// <returns>the webhook's response</returns>
        public string SendWebhookRequest(string webid, string param, string body = "", string conttype = "")
        {
            Checkinit();

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook")),
                ["webid"] = Encryption.Encrypt(webid, enckey, init_iv),
                ["params"] = Encryption.Encrypt(param, enckey, init_iv),
                ["body"] = Encryption.Encrypt(body, enckey, init_iv),
                ["conttype"] = Encryption.Encrypt(conttype, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);

            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                return json.response;
            return null;
        }

        // KeyAuth acts as proxy and downlods the file in a secure way
        /// <param name="fileid">File ID</param>
        /// <returns>The bytes of the download file</returns>
        public byte[] DownloadFile(string fileid)
        {
            Checkinit();

            var init_iv = Encryption.sha256(Encryption.iv_key());

            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("file")),
                ["fileid"] = Encryption.Encrypt(fileid, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            var responseRequest = SendRequest(values_to_upload);

            responseRequest = Encryption.Decrypt(responseRequest, enckey, init_iv);

            var json = response_decoder.string_to_generic<ResponseStructure>(responseRequest);
            LoadResponseStruct(json);
            if (json.success)
                return Encryption.str_to_byte_arr(json.contents);
            return null;
        }

        // Logs the IP address,PC Name with a message, if a discord webhook is set up in the app settings, the log will get sent there and the dashboard if not set up it will only be in the dashboard
        /// <param name="message">Message</param>
        public void WriteLog(string message)
        {
            Checkinit();

            var init_iv = Encryption.sha256(Encryption.iv_key());
            var values_to_upload = new NameValueCollection
            {
                ["type"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes("log")),
                ["pcuser"] = Encryption.Encrypt(Environment.UserName, enckey, init_iv),
                ["message"] = Encryption.Encrypt(message, enckey, init_iv),
                ["sessionid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(sessionid)),
                ["name"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(name)),
                ["ownerid"] = Encryption.byte_arr_to_str(Encoding.Default.GetBytes(ownerid)),
                ["init_iv"] = init_iv
            };

            SendRequest(values_to_upload);
        }

        public static string GenerateChecksum(string filename)
        {
            string result;
            using (MD5 md = MD5.Create())
            {
                using (FileStream fileStream = File.OpenRead(filename))
                {
                    byte[] value = md.ComputeHash(fileStream);
                    result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
                }
            }
            return result;
        }

        public static void GenerateError(string message)
        {
            Process.Start(new ProcessStartInfo("cmd.exe", $"/c start cmd /C \"color b && title Error && echo {message} && timeout /t 5\"")
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            });
            Environment.Exit(0);
        }

        private static string SendRequest(NameValueCollection _postData)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    var raw_response = client.UploadValues("https://keyauth.win/api/1.0/", _postData);

                    return Encoding.Default.GetString(raw_response);
                }
            }
            catch (WebException webex)
            {
                var response = (HttpWebResponse)webex.Response;
                switch (response.StatusCode)
                {
                    case (HttpStatusCode)429: // client hit our rate limit
                        Thread.Sleep(1000);
                        return SendRequest(_postData);

                    default: // site won't resolve. you should use keyauth.uk domain since it's not blocked by any ISPs
                        GenerateError("Connection failure. Please try again, or contact us for help.");
                        Environment.Exit(0);
                        return "";
                }
            }
        }

        #region app_data

        private void LoadAppData(AppDataStructure data)
        {
            app_data.numUsers = data.numUsers;
            app_data.numOnlineUsers = data.numOnlineUsers;
            app_data.numKeys = data.numKeys;
            app_data.version = data.version;
            app_data.customerPanelLink = data.customerPanelLink;
        }

        #endregion app_data

        #region user_data

        private void LoadUserData(UserDataStructure data)
        {
            user_data.username = data.username;
            user_data.ip = data.ip;
            user_data.hwid = data.hwid;
            user_data.createdate = data.createdate;
            user_data.lastlogin = data.lastlogin;
            user_data.subscriptions = data.subscriptions; // array of subscriptions (basically multiple user ranks for user with individual expiry dates
        }

        #endregion user_data

        public string GetExpiryDaysHoursMinutesLeft()
        {
            Checkinit();

            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(user_data.subscriptions[0].expiry)).ToLocalTime();
            TimeSpan difference = dtDateTime - DateTime.Now;
            return Convert.ToString(difference.Days + " Dias " + difference.Hours + " Horas e " + difference.Minutes + " Minutos");
        }

        public string GetExpiryDaysLeft()
        {
            Checkinit();

            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(user_data.subscriptions[0].expiry)).ToLocalTime();
            TimeSpan difference = dtDateTime - DateTime.Now;
            return Convert.ToString(difference.Days + " Dias ");
        }

        #region response_struct

        private void LoadResponseStruct(ResponseStructure data)
        {
            response.success = data.success;
            response.message = data.message;
        }

        #endregion response_struct

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }
    }
}