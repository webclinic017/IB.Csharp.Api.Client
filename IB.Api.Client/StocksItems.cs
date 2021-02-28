namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class StocksItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public Properties7 Properties { get; set; }
    }
}
