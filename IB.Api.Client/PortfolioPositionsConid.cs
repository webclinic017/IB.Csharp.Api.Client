namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PortfolioPositionsConid
    {
        [JsonProperty("get")]
        public PortfolioPositionsConidGet Get { get; set; }
    }
}
