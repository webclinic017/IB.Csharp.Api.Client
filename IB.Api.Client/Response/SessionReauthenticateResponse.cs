using Newtonsoft.Json;

namespace IB.Api.Client.Response
{
    public class SessionReauthenticateResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}