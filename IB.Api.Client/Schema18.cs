namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema18
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties55 Properties { get; set; }
    }
}
