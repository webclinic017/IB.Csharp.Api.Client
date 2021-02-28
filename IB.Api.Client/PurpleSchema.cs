namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleSchema
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties13 Properties { get; set; }
    }
}
