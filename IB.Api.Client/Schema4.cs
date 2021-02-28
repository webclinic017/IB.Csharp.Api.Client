namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema4
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties32 Properties { get; set; }
    }
}
