namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema6
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties34 Properties { get; set; }
    }
}
