namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ModifyOrderProperties
    {
        [JsonProperty("acctId")]
        public AccountAlias AcctId { get; set; }

        [JsonProperty("conid")]
        public AccountAlias Conid { get; set; }

        [JsonProperty("orderType")]
        public AlertMessage OrderType { get; set; }

        [JsonProperty("outsideRTH")]
        public AccountAlias OutsideRth { get; set; }

        [JsonProperty("price")]
        public AccountAlias Price { get; set; }

        [JsonProperty("auxPrice")]
        public AccountAlias AuxPrice { get; set; }

        [JsonProperty("side")]
        public AlertMessage Side { get; set; }

        [JsonProperty("listingExchange")]
        public AlertMessage ListingExchange { get; set; }

        [JsonProperty("ticker")]
        public AccountAlias Ticker { get; set; }

        [JsonProperty("tif")]
        public AlertMessage Tif { get; set; }

        [JsonProperty("quantity")]
        public AlertMessage Quantity { get; set; }
    }
}
