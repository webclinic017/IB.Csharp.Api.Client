using Newtonsoft.Json;

namespace IB.Api.Client.Model
{
    public class Equity
    {
        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("change")]
        public long Change { get; set; }

        [JsonProperty("after")]
        public string After { get; set; }
    }
}
