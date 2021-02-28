using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Session.Response
{
    public class ReauthenticateSessionResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
