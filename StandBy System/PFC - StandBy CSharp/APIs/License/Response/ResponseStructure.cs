using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PFC___StandBy_CSharp.APIs.License
{
    public partial class Api
    {
        [DataContract]
        private class ResponseStructure
        {
            [DataMember]
            public bool success { get; set; }

            [DataMember]
            public string sessionid { get; set; }

            [DataMember]
            public string contents { get; set; }

            [DataMember]
            public string response { get; set; }

            [DataMember]
            public string message { get; set; }

            [DataMember]
            public string download { get; set; }

            [DataMember(IsRequired = false, EmitDefaultValue = false)]
            public UserDataStructure info { get; set; }

            [DataMember(IsRequired = false, EmitDefaultValue = false)]
            public AppDataStructure appinfo { get; set; }

            [DataMember]
            public List<Message> messages { get; set; }
        }
    }
}