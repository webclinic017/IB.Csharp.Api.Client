using IB.Api.Client.Endpoint.Accounts.Model;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Accounts.Response
{
    public class AccountLedgerResponse
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