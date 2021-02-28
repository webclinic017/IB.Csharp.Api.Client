using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Session.Response
{
    public class SessionStatusResponse
    {
        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }

        [JsonProperty("competing")]
        public bool Competing { get; set; }

        [JsonProperty("connected")]
        public bool Connected { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("MAC")]
        public string Mac { get; set; }

        [JsonProperty("fail")]
        public string Fail { get; set; }
    }
}
