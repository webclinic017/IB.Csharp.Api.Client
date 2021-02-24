using IB.Api.Client.Model.Enum;
using Newtonsoft.Json;

namespace IB.Api.Client.Request
{
    public class OrderPreviewRequest
    {
        [JsonProperty("acctId")]
        public string AccountId { get; set; }

        [JsonProperty("conid")]
        public int ContractId { get; set; }

        [JsonProperty("secType")]
        public string SecType { get; set; }

        [JsonProperty("cOID")]
        public string CustomerOrderId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("orderType")]
        public OrderType OrderType { get; set; }

        [JsonProperty("listingExchange")]
        public Exchange ListingExchange { get; set; }

        [JsonProperty("outsideRTH")]
        public bool OutsideRegularHours { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("side")]
        public Side Side { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("tif")]
        public Expiry Expiry { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("fxQty")]
        public double FxQty { get; set; }

        [JsonProperty("useAdaptive")]
        public bool UseAdaptive { get; set; }

        [JsonProperty("isCurrencyConversion")]
        public bool IsCurrencyConversion { get; set; }

        [JsonProperty("allocationMethod")]
        public AllocationMethod AllocationMethod { get; set; }
    }
}