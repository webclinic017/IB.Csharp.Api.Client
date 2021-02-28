namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyRules
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public RulesItems Items { get; set; }
    }
}
