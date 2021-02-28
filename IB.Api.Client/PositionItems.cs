namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PositionItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public Properties2 Properties { get; set; }
    }
}
