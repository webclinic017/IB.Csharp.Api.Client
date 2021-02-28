namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SecdefInfoProperties
    {
        [JsonProperty("conid")]
        public AccountAlias Conid { get; set; }

        [JsonProperty("symbol")]
        public AlertMessage Symbol { get; set; }

        [JsonProperty("secType")]
        public AccountAlias SecType { get; set; }

        [JsonProperty("exchange")]
        public AccountAlias Exchange { get; set; }

        [JsonProperty("listingExchange")]
        public AccountAlias ListingExchange { get; set; }

        [JsonProperty("right")]
        public AlertMessage Right { get; set; }

        [JsonProperty("strike")]
        public AlertMessage Strike { get; set; }

        [JsonProperty("currency")]
        public AlertMessage Currency { get; set; }

        [JsonProperty("cusip")]
        public AlertMessage Cusip { get; set; }

        [JsonProperty("coupon")]
        public AlertMessage Coupon { get; set; }

        [JsonProperty("desc1")]
        public AlertMessage Desc1 { get; set; }

        [JsonProperty("desc2")]
        public AlertMessage Desc2 { get; set; }

        [JsonProperty("maturityDate")]
        public AlertMessage MaturityDate { get; set; }

        [JsonProperty("multiplier")]
        public AlertMessage Multiplier { get; set; }

        [JsonProperty("tradingClass")]
        public AccountAlias TradingClass { get; set; }

        [JsonProperty("validExchanges")]
        public AccountAlias ValidExchanges { get; set; }
    }
}
