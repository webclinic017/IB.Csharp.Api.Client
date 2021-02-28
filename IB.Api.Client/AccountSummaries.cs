namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AccountSummaries
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public AccountSummariesItems Items { get; set; }
    }
}
