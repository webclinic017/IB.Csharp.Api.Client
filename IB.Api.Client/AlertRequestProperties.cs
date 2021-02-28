namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AlertRequestProperties
    {
        [JsonProperty("orderId")]
        public AlertMessage OrderId { get; set; }

        [JsonProperty("alertName")]
        public AlertMessage AlertName { get; set; }

        [JsonProperty("alertMessage")]
        public AlertMessage AlertMessage { get; set; }

        [JsonProperty("alertRepeatable")]
        public AlertMessage AlertRepeatable { get; set; }

        [JsonProperty("email")]
        public AlertMessage Email { get; set; }

        [JsonProperty("sendMessage")]
        public AlertMessage SendMessage { get; set; }

        [JsonProperty("tif")]
        public AlertMessage Tif { get; set; }

        [JsonProperty("expireTime")]
        public ExpireTime ExpireTime { get; set; }

        [JsonProperty("outsideRth")]
        public AlertMessage OutsideRth { get; set; }

        [JsonProperty("iTWSOrdersOnly")]
        public AlertMessage ITwsOrdersOnly { get; set; }

        [JsonProperty("showPopup")]
        public AlertMessage ShowPopup { get; set; }

        [JsonProperty("toolId")]
        public AlertMessage ToolId { get; set; }

        [JsonProperty("playAudio")]
        public AlertMessage PlayAudio { get; set; }

        [JsonProperty("conditions")]
        public PurpleConditions Conditions { get; set; }
    }
}
