using System.Collections.Generic;

namespace PFC___StandBy_CSharp.APIs.License
{
    public partial class Api
    {
        public class UserDataClass
        {
            public string username { get; set; }
            public string ip { get; set; }
            public string hwid { get; set; }
            public string createdate { get; set; }
            public string lastlogin { get; set; }
            public List<UserSubscriptionData> subscriptions { get; set; } // array of subscriptions (basically multiple user ranks for user with individual expiry dates
        }
    }
}