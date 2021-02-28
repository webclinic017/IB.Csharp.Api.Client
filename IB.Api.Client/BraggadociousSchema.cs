namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class BraggadociousSchema
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties28 Properties { get; set; }
    }
}
