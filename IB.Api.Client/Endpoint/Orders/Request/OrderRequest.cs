using IB.Api.Client.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IB.Api.Client.Endpoint.Orders.Request
{
    public class OrderRequest
    {
        [JsonProperty("acctId")]
        public string AccountId { get; set; }

        [JsonProperty("conid")]
        public long ContractId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("secType")]
        public SecurityType SecType { get; set; }

        [JsonProperty("cOID")]
        public string CustomerOrderId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("orderType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderType OrderType { get; set; }

        [JsonProperty("listingExchange")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Exchange ListingExchange { get; set; }

        [JsonProperty("outsideRTH")]
        public bool OutsideRegularHours { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("side")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Side Side { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("tif")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeInForce Expiry { get; set; }

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
        [JsonConverter(typeof(StringEnumConverter))]
        public AllocationMethod? AllocationMethod { get; set; }
    }
}
