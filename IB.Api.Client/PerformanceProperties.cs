namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PerformanceProperties
    {
        [JsonProperty("id")]
        public AccountAlias Id { get; set; }

        [JsonProperty("cps")]
        public Cps Cps { get; set; }

        [JsonProperty("tpps")]
        public Cps Tpps { get; set; }

        [JsonProperty("nav")]
        public Cps Nav { get; set; }

        [JsonProperty("pm")]
        public AccountAlias Pm { get; set; }

        [JsonProperty("included")]
        public Included Included { get; set; }

        [JsonProperty("currencyType")]
        public AccountAlias CurrencyType { get; set; }

        [JsonProperty("rc")]
        public AccountAlias Rc { get; set; }
    }
}
