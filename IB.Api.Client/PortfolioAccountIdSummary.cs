namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PortfolioAccountIdSummary
    {
        [JsonProperty("get")]
        public PortfolioAccountIdSummaryGet Get { get; set; }
    }
}
