namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TradingTimesProperties
    {
        [JsonProperty("openingTime")]
        public AccountAlias OpeningTime { get; set; }

        [JsonProperty("closingTime")]
        public AccountAlias ClosingTime { get; set; }

        [JsonProperty("cancelDayOrders")]
        public AccountAlias CancelDayOrders { get; set; }
    }
}
