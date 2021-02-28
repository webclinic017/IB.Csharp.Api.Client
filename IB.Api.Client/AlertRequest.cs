namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AlertRequest
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public AlertRequestProperties Properties { get; set; }
    }
}
