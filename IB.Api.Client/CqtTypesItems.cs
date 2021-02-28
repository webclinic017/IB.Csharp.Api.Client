namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class CqtTypesItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties37 Properties { get; set; }
    }
}
