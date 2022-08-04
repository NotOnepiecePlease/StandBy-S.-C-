using System.Runtime.Serialization;

namespace PFC___StandBy_CSharp.APIs.License
{
    public partial class Api
    {
        [DataContract]
        private class AppDataStructure
        {
            [DataMember]
            public string numUsers { get; set; }

            [DataMember]
            public string numOnlineUsers { get; set; }

            [DataMember]
            public string numKeys { get; set; }

            [DataMember]
            public string version { get; set; }

            [DataMember]
            public string customerPanelLink { get; set; }

            [DataMember]
            public string downloadLink { get; set; }
        }
    }
}