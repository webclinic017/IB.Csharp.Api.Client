namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class StatsDataProperties
    {
        [JsonProperty("Conid")]
        public AccountAlias Conid { get; set; }

        [JsonProperty("Exchange")]
        public AccountAlias Exchange { get; set; }

        [JsonProperty("V")]
        public AccountAlias V { get; set; }

        [JsonProperty("T")]
        public AccountAlias T { get; set; }

        [JsonProperty("TT")]
        public AccountAlias Tt { get; set; }

        [JsonProperty("P")]
        public AlertMessage P { get; set; }
    }
}
