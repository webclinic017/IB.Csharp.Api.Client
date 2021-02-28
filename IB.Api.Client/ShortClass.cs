namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ShortClass
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public StickyProperties Properties { get; set; }
    }
}
