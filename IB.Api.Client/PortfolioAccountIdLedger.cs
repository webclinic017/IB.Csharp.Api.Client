namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PortfolioAccountIdLedger
    {
        [JsonProperty("get")]
        public PortfolioAccountIdLedgerGet Get { get; set; }
    }
}
