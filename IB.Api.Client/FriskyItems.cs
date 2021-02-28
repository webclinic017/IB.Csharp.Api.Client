namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FriskyItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties50 Properties { get; set; }
    }
}
