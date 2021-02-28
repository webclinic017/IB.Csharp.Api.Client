namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema2
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties30 Properties { get; set; }
    }
}
