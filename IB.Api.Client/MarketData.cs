namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MarketData
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public MarketDataProperties Properties { get; set; }
    }
}
