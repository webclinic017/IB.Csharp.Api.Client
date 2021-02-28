namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class BarsProperties
    {
        [JsonProperty("open")]
        public AccountAlias Open { get; set; }

        [JsonProperty("high")]
        public AccountAlias High { get; set; }

        [JsonProperty("low")]
        public AccountAlias Low { get; set; }

        [JsonProperty("close")]
        public AccountAlias Close { get; set; }

        [JsonProperty("volume")]
        public AccountAlias Volume { get; set; }

        [JsonProperty("time")]
        public AccountAlias Time { get; set; }

        [JsonProperty("endTime")]
        public AccountAlias EndTime { get; set; }

        [JsonProperty("weightedAvg")]
        public AccountAlias WeightedAvg { get; set; }

        [JsonProperty("count")]
        public AccountAlias Count { get; set; }
    }
}
