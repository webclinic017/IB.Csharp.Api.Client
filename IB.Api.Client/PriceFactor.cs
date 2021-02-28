namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PriceFactor
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public long Example { get; set; }
    }
}
