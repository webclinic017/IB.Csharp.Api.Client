namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Equity
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public EquityProperties Properties { get; set; }
    }
}
