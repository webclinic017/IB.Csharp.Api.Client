namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties31
    {
        [JsonProperty("amount")]
        public Amount Amount { get; set; }

        [JsonProperty("equity")]
        public Equity Equity { get; set; }

        [JsonProperty("initial")]
        public Equity Initial { get; set; }

        [JsonProperty("maintenance")]
        public Equity Maintenance { get; set; }

        [JsonProperty("warn")]
        public AccountAlias Warn { get; set; }

        [JsonProperty("error")]
        public AccountAlias Error { get; set; }
    }
}
