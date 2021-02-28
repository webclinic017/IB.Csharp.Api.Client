namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ModifyOrder
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public ModifyOrderProperties Properties { get; set; }
    }
}
