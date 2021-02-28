using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Accounts.Model
{
    public class Master
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("officialTitle")]
        public string OfficialTitle { get; set; }
    }
}
