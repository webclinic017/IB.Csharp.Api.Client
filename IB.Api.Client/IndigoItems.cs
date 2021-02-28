namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndigoItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties19 Properties { get; set; }
    }
}
