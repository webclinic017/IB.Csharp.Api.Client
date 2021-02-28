namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FuturesItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public MagentaProperties Properties { get; set; }
    }
}
