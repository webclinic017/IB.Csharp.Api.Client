using Newtonsoft.Json;

namespace IB.Api.Client.Model
{
    public class AuthStatus
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
    }
}
