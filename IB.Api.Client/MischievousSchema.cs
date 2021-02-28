namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MischievousSchema
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties27 Properties { get; set; }
    }
}
