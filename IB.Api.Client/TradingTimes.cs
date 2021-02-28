namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TradingTimes
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public TradingTimesProperties Properties { get; set; }
    }
}
