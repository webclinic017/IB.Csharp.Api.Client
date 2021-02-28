namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class HilariousSchema
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties20 Properties { get; set; }
    }
}
