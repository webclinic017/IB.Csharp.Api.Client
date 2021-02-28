namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class CunningSchema
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties24 Properties { get; set; }
    }
}
