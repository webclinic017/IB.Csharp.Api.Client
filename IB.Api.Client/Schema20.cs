namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema20
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties56 Properties { get; set; }
    }
}
