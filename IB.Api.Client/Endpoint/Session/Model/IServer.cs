using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Session.Model
{
    public class IServer
    {
        [JsonProperty("tickle")]
        public bool Tickle { get; set; }

        [JsonProperty("authStatus")]
        public AuthStatus AuthStatus { get; set; }
    }
}
