using IB.Api.Client.Model;
using Newtonsoft.Json;

namespace IB.Api.Client.Response
{
    public class SessionTickleResponse
    {
        [JsonProperty("session")]
        public string Session { get; set; }

        [JsonProperty("ssoExpires")]
        public long SsoExpires { get; set; }

        [JsonProperty("collission")]
        public bool Collission { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }

        [JsonProperty("iserver")]
        public IServer Iserver { get; set; }
    }
}
