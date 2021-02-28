namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AssetClass
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }
    }
}
