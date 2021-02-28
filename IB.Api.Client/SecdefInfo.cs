namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SecdefInfo
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public SecdefInfoProperties Properties { get; set; }
    }
}
