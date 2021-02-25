using IB.Api.Client.Model.Enum;
using Newtonsoft.Json;

namespace IB.Api.Client.Model
{
    public class Order
    {
        [JsonProperty("acct")]
        public string Acct { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

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

        [JsonProperty("origOrderType")]
        public string OrigOrderType { get; set; }

        [JsonProperty("supportsTaxOpt")]
        public long SupportsTaxOpt { get; set; }

        [JsonProperty("lastExecutionTime")]
        public long LastExecutionTime { get; set; }

        [JsonProperty("lastExecutionTime_r")]
        public long LastExecutionTimeR { get; set; }

        [JsonProperty("orderType")]
        public string OrderType { get; set; }

        [JsonProperty("order_ref")]
        public string OrderRef { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("timeInForce")]
        public TimeInForce TimeInForce { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("bgColor")]
        public string BgColor { get; set; }

        [JsonProperty("fgColor")]
        public string FgColor { get; set; }
    }
}