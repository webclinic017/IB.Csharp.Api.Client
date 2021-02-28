namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ExcludedAccounts
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public Ledger Items { get; set; }
    }
}
