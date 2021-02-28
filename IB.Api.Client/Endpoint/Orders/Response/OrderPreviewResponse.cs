using IB.Api.Client.Endpoint.Orders.Model;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Orders.Response
{
    public class OrderPreviewResponse
    {
        [JsonProperty("amount")]
        public Amount Amount { get; set; }

        [JsonProperty("equity")]
        public Equity Equity { get; set; }

        [JsonProperty("initial")]
        public Equity Initial { get; set; }

        [JsonProperty("maintenance")]
        public Equity Maintenance { get; set; }

        [JsonProperty("warn")]
        public string Warn { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }
}