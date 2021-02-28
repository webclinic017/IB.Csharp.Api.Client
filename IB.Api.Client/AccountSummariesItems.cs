namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AccountSummariesItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties9 Properties { get; set; }
    }
}
