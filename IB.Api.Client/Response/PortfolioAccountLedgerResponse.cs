using IB.Api.Client.Model;
using Newtonsoft.Json;

namespace IB.Api.Client.Response
{
    public class PortfolioAccountLedgerResponse
    {
        [JsonProperty("EUR")]
        public LedgerItem Eur { get; set; }

        [JsonProperty("GBP")]
        public LedgerItem Gbp { get; set; }

        [JsonProperty("USD")]
        public LedgerItem Usd { get; set; }

        [JsonProperty("BASE")]
        public LedgerItem Base { get; set; }
    }
}
