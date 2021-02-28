namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class RulesItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties36 Properties { get; set; }
    }
}
