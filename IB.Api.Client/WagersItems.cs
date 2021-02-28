namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class WagersItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public Properties12 Properties { get; set; }
    }
}
