using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Session.Response
{
    public class SessionReauthenticateResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
