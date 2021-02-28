namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties23
    {
        [JsonProperty("country")]
        public AccountAlias Country { get; set; }

        [JsonProperty("state")]
        public AccountAlias State { get; set; }

        [JsonProperty("type")]
        public AccountAlias Type { get; set; }

        [JsonProperty("value")]
        public AccountAlias Value { get; set; }
    }
}
