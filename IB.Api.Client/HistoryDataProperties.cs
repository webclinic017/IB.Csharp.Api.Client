namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class HistoryDataProperties
    {
        [JsonProperty("symbol")]
        public AlertMessage Symbol { get; set; }

        [JsonProperty("text")]
        public AlertMessage Text { get; set; }

        [JsonProperty("priceFactor")]
        public PriceFactor PriceFactor { get; set; }

        [JsonProperty("startTime")]
        public AlertMessage StartTime { get; set; }

        [JsonProperty("high")]
        public AlertMessage High { get; set; }

        [JsonProperty("low")]
        public AlertMessage Low { get; set; }

        [JsonProperty("timePeriod")]
        public AlertMessage TimePeriod { get; set; }

        [JsonProperty("barLength")]
        public AlertMessage BarLength { get; set; }

        [JsonProperty("mdAvailability")]
        public AlertMessage MdAvailability { get; set; }

        [JsonProperty("mktDataDelay")]
        public AlertMessage MktDataDelay { get; set; }

        [JsonProperty("outsideRth")]
        public AlertMessage OutsideRth { get; set; }

        [JsonProperty("tradingDayDuration")]
        public AlertMessage TradingDayDuration { get; set; }

        [JsonProperty("volumeFactor")]
        public AccountAlias VolumeFactor { get; set; }

        [JsonProperty("priceDisplayRule")]
        public AccountAlias PriceDisplayRule { get; set; }

        [JsonProperty("priceDisplayValue")]
        public AccountAlias PriceDisplayValue { get; set; }

        [JsonProperty("negativeCapable")]
        public AccountAlias NegativeCapable { get; set; }

        [JsonProperty("messageVersion")]
        public AccountAlias MessageVersion { get; set; }

        [JsonProperty("data")]
        public PurpleData Data { get; set; }

        [JsonProperty("points")]
        public AlertMessage Points { get; set; }

        [JsonProperty("travelTime")]
        public AccountAlias TravelTime { get; set; }
    }
}
