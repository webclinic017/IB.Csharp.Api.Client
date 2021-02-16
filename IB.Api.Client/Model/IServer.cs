using Newtonsoft.Json;

namespace IB.Api.Client.Model
{
    public class IServer
    {
        [JsonProperty("tickle")]
        public bool Tickle { get; set; }

        [JsonProperty("authStatus")]
        public AuthStatus AuthStatus { get; set; }
    }
}
