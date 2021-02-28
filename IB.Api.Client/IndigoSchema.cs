namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndigoSchema
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties18 Properties { get; set; }
    }
}
