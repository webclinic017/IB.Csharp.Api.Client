namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class StickySchema
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties17 Properties { get; set; }
    }
}
