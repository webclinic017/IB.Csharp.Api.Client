using System.Collections.Generic;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Session.Response
{
    public class ReauthenticateSessionResponse
    {
        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }

        [JsonProperty("connected")]
        public bool Connected { get; set; }

        [JsonProperty("competing")]
        public bool Competing { get; set; }

        [JsonProperty("fail")]
        public string Fail { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("prompts")]
        public List<string> Prompts { get; set; }
    }
}
