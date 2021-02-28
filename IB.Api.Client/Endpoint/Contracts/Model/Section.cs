using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Contracts.Model
{
    public class Section
    {
        [JsonProperty("secType")]
        public string SecType { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("conid")]
        public long Conid { get; set; }
    }
}
