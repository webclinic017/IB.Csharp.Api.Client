namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema3
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties31 Properties { get; set; }
    }
}
