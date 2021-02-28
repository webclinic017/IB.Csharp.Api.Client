namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MagentaItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties40 Properties { get; set; }
    }
}
