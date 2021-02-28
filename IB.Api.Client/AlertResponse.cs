namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AlertResponse
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public AlertResponseProperties Properties { get; set; }
    }
}
