namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MarketDataProperties
    {
        [JsonProperty("Conid")]
        public AlertMessage Conid { get; set; }

        [JsonProperty("Exchange")]
        public AlertMessage Exchange { get; set; }

        [JsonProperty("minTick")]
        public AccountAlias MinTick { get; set; }

        [JsonProperty("Last")]
        public AccountAlias Last { get; set; }

        [JsonProperty("LastSize")]
        public AccountAlias LastSize { get; set; }

        [JsonProperty("Bid")]
        public AccountAlias Bid { get; set; }

        [JsonProperty("BidSize")]
        public AccountAlias BidSize { get; set; }

        [JsonProperty("Ask")]
        public AccountAlias Ask { get; set; }

        [JsonProperty("AskSize")]
        public AccountAlias AskSize { get; set; }
    }
}
