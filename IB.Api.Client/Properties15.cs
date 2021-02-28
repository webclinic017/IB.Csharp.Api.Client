namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties15
    {
        [JsonProperty("devicename", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAlias Devicename { get; set; }

        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAlias DeviceId { get; set; }

        [JsonProperty("uiName", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAlias UiName { get; set; }

        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAlias Enabled { get; set; }

        [JsonProperty("alertId", NullValueHandling = NullValueHandling.Ignore)]
        public AlertMessage AlertId { get; set; }

        [JsonProperty("alertActive", NullValueHandling = NullValueHandling.Ignore)]
        public AlertMessage AlertActive { get; set; }

        [JsonProperty("orders", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleOrders Orders { get; set; }

        [JsonProperty("confirmed", NullValueHandling = NullValueHandling.Ignore)]
        public AlertMessage Confirmed { get; set; }

        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public AlertMessage Symbol { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public AlertMessage Name { get; set; }

        [JsonProperty("secType", NullValueHandling = NullValueHandling.Ignore)]
        public AlertMessage SecType { get; set; }

        [JsonProperty("acctIds", NullValueHandling = NullValueHandling.Ignore)]
        public Included AcctIds { get; set; }

        [JsonProperty("freq", NullValueHandling = NullValueHandling.Ignore)]
        public Freq Freq { get; set; }

        [JsonProperty("conids", NullValueHandling = NullValueHandling.Ignore)]
        public Included Conids { get; set; }
    }
}
