namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema7
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties35 Properties { get; set; }
    }
}
