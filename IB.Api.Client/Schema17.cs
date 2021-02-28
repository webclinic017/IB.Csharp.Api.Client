namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema17
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties54 Properties { get; set; }
    }
}
