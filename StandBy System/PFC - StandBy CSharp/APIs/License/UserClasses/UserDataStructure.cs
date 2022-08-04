using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PFC___StandBy_CSharp.APIs.License
{
    public partial class Api
    {
        [DataContract]
        private class UserDataStructure
        {
            [DataMember]
            public string username { get; set; }

            [DataMember]
            public string ip { get; set; }

            [DataMember]
            public string hwid { get; set; }

            [DataMember]
            public string createdate { get; set; }

            [DataMember]
            public string lastlogin { get; set; }

            [DataMember]
            public List<UserSubscriptionData> subscriptions { get; set; } // array of subscriptions (basically multiple user ranks for user with individual expiry dates
        }
    }
}