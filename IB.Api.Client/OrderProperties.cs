namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class OrderProperties
    {
        [JsonProperty("acct")]
        public AlertMessage Acct { get; set; }

        [JsonProperty("conid")]
        public AccountAlias Conid { get; set; }

        [JsonProperty("orderDesc")]
        public AccountAlias OrderDesc { get; set; }

        [JsonProperty("description1")]
        public AccountAlias Description1 { get; set; }

        [JsonProperty("ticker")]
        public AlertMessage Ticker { get; set; }

        [JsonProperty("secType")]
        public AlertMessage SecType { get; set; }

        [JsonProperty("listingExchange")]
        public AlertMessage ListingExchange { get; set; }

        [JsonProperty("remainingQuantity")]
        public AccountAlias RemainingQuantity { get; set; }

        [JsonProperty("filledQuantity")]
        public AccountAlias FilledQuantity { get; set; }

        [JsonProperty("companyName")]
        public AccountAlias CompanyName { get; set; }

        [JsonProperty("status")]
        public AlertMessage Status { get; set; }

        [JsonProperty("origOrderType")]
        public AlertMessage OrigOrderType { get; set; }

        [JsonProperty("side")]
        public AlertMessage Side { get; set; }

        [JsonProperty("price")]
        public AccountAlias Price { get; set; }

        [JsonProperty("bgColor")]
        public AlertMessage BgColor { get; set; }

        [JsonProperty("fgColor")]
        public AccountAlias FgColor { get; set; }

        [JsonProperty("orderId")]
        public AccountAlias OrderId { get; set; }

        [JsonProperty("parentId")]
        public AlertMessage ParentId { get; set; }

        [JsonProperty("order_ref")]
        public AlertMessage OrderRef { get; set; }
    }
}
