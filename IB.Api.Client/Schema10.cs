namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema10
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties42 Properties { get; set; }
    }
}
