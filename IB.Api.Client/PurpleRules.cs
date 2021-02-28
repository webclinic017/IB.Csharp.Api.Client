namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleRules
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public RulesProperties Properties { get; set; }
    }
}
