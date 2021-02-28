namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class StickyItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties1 Properties { get; set; }
    }
}
