namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AlertMessage
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
