namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties36
    {
        [JsonProperty("error")]
        public AccountAlias Error { get; set; }

        [JsonProperty("orderTypes")]
        public CqtTypes OrderTypes { get; set; }

        [JsonProperty("ibalgoTypes")]
        public CqtTypes IbalgoTypes { get; set; }

        [JsonProperty("fraqTypes")]
        public CqtTypes FraqTypes { get; set; }

        [JsonProperty("cqtTypes")]
        public CqtTypes CqtTypes { get; set; }

        [JsonProperty("orderDefaults")]
        public OrderDefaults OrderDefaults { get; set; }

        [JsonProperty("orderTypesOutside")]
        public CqtTypes OrderTypesOutside { get; set; }

        [JsonProperty("defaultSize")]
        public AlertMessage DefaultSize { get; set; }

        [JsonProperty("cashSize")]
        public AlertMessage CashSize { get; set; }

        [JsonProperty("sizeIncrement")]
        public AlertMessage SizeIncrement { get; set; }

        [JsonProperty("tifTypes")]
        public CqtTypes TifTypes { get; set; }

        [JsonProperty("defaultTIF")]
        public AlertMessage DefaultTif { get; set; }

        [JsonProperty("limitPrice")]
        public AlertMessage LimitPrice { get; set; }

        [JsonProperty("stopprice")]
        public AlertMessage Stopprice { get; set; }

        [JsonProperty("orderOrigination")]
        public AlertMessage OrderOrigination { get; set; }

        [JsonProperty("preview")]
        public AlertMessage Preview { get; set; }

        [JsonProperty("displaySize")]
        public AccountAlias DisplaySize { get; set; }

        [JsonProperty("fraqInt")]
        public AlertMessage FraqInt { get; set; }

        [JsonProperty("cashCcy")]
        public AlertMessage CashCcy { get; set; }

        [JsonProperty("cashQtyIncr")]
        public AlertMessage CashQtyIncr { get; set; }

        [JsonProperty("priceMagnifier")]
        public AlertMessage PriceMagnifier { get; set; }

        [JsonProperty("negativeCapable")]
        public AlertMessage NegativeCapable { get; set; }

        [JsonProperty("increment")]
        public AlertMessage Increment { get; set; }

        [JsonProperty("incrementDigits")]
        public AlertMessage IncrementDigits { get; set; }
    }
}
