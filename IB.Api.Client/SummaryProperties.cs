namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SummaryProperties
    {
        [JsonProperty("total")]
        public Total Total { get; set; }

        [JsonProperty("startDate")]
        public AlertMessage StartDate { get; set; }

        [JsonProperty("excludedAccounts")]
        public ExcludedAccounts ExcludedAccounts { get; set; }

        [JsonProperty("lastSuccessfulUpdate")]
        public AccountAlias LastSuccessfulUpdate { get; set; }

        [JsonProperty("accountSummaries")]
        public AccountSummaries AccountSummaries { get; set; }

        [JsonProperty("endDate")]
        public AccountAlias EndDate { get; set; }

        [JsonProperty("hasExternalAccounts")]
        public AlertMessage HasExternalAccounts { get; set; }

        [JsonProperty("rc")]
        public AccountAlias Rc { get; set; }

        [JsonProperty("currency")]
        public AccountAlias Currency { get; set; }

        [JsonProperty("userId")]
        public AccountAlias UserId { get; set; }

        [JsonProperty("pm")]
        public AccountAlias Pm { get; set; }

        [JsonProperty("view")]
        public AccountAlias View { get; set; }

        [JsonProperty("balanceByDate")]
        public BalanceByDate BalanceByDate { get; set; }
    }
}
