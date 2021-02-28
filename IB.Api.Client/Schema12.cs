namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema12
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties44 Properties { get; set; }
    }
}
