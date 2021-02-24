using Newtonsoft.Json;

namespace IB.Api.Client.Model
{
    public class Amount
    {
        [JsonProperty("amount")]
        public string Value { get; set; }

        [JsonProperty("commission")]
        public string Commission { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }
}
