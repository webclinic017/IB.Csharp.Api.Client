namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TentacledItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public FriskyProperties Properties { get; set; }
    }
}
