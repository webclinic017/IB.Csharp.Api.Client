using IB.Api.Client.Enum;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Orders.Model
{
    public class Order
    {
        [JsonProperty("acct")]
        public string Acct { get; set; }

        [JsonProperty("conid")]
        public long Conid { get; set; }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonProperty("cashCcy")]
        public string CashCcy { get; set; }

        [JsonProperty("sizeAndFills")]
        public string SizeAndFills { get; set; }

        [JsonProperty("orderDesc")]
        public string OrderDesc { get; set; }

        [JsonProperty("description1")]
        public string Description1 { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("secType")]
        public string SecType { get; set; }

        [JsonProperty("listingExchange")]
        public string ListingExchange { get; set; }

        [JsonProperty("remainingQuantity")]
        public long RemainingQuantity { get; set; }

        [JsonProperty("filledQuantity")]
        public long FilledQuantity { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("status")]
        public OrderStatus Status { get; set; }

        [JsonProperty("avgPrice")]
        public string AvgPrice { get; set; }

        [JsonProperty("origOrderType")]
        public string OrigOrderType { get; set; }

        [JsonProperty("supportsTaxOpt")]
        public string SupportsTaxOpt { get; set; }

        [JsonProperty("lastExecutionTime")]
        public string LastExecutionTime { get; set; }

        [JsonProperty("lastExecutionTime_r")]
        public long LastExecutionTimeR { get; set; }

        [JsonProperty("orderType")]
        public string OrderType { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }

        [JsonProperty("bgColor")]
        public string BgColor { get; set; }

        [JsonProperty("fgColor")]
        public string FgColor { get; set; }
    }
}
