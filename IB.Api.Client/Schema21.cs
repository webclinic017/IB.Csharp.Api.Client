namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema21
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties57 Properties { get; set; }
    }
}
