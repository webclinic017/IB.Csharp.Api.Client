using System.Collections.Generic;
using Newtonsoft.Json;

namespace IB.Api.Client.Response
{
    public class ReauthenticateResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}