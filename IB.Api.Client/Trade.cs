namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Trade
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public TradeProperties Properties { get; set; }
    }
}
