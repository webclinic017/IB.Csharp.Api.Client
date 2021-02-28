namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties52
    {
        [JsonProperty("secType")]
        public AlertMessage SecType { get; set; }

        [JsonProperty("months")]
        public AlertMessage Months { get; set; }

        [JsonProperty("symbol")]
        public AccountAlias Symbol { get; set; }

        [JsonProperty("exchange")]
        public AlertMessage Exchange { get; set; }

        [JsonProperty("legSecType")]
        public AlertMessage LegSecType { get; set; }
    }
}
