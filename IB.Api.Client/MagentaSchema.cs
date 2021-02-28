namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MagentaSchema
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties25 Properties { get; set; }
    }
}
