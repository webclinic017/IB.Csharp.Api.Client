namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AlertResponseProperties
    {
        [JsonProperty("account")]
        public AlertMessage Account { get; set; }

        [JsonProperty("order_id")]
        public AccountAlias OrderId { get; set; }

        [JsonProperty("alert_name")]
        public AlertMessage AlertName { get; set; }

        [JsonProperty("alert_message")]
        public AlertMessage AlertMessage { get; set; }

        [JsonProperty("alert_active")]
        public AlertMessage AlertActive { get; set; }

        [JsonProperty("alert_repeatable")]
        public AlertMessage AlertRepeatable { get; set; }

        [JsonProperty("alert_email")]
        public AlertMessage AlertEmail { get; set; }

        [JsonProperty("alert_send_message")]
        public AlertMessage AlertSendMessage { get; set; }

        [JsonProperty("tif")]
        public AlertMessage Tif { get; set; }

        [JsonProperty("expire_time")]
        public ExpireTime ExpireTime { get; set; }

        [JsonProperty("order_status")]
        public ExpireTime OrderStatus { get; set; }

        [JsonProperty("outsideRth")]
        public AlertMessage OutsideRth { get; set; }

        [JsonProperty("itws_orders_only")]
        public AlertMessage ItwsOrdersOnly { get; set; }

        [JsonProperty("alert_show_popup")]
        public AlertMessage AlertShowPopup { get; set; }

        [JsonProperty("alert_triggered")]
        public AlertMessage AlertTriggered { get; set; }

        [JsonProperty("order_not_editable")]
        public AlertMessage OrderNotEditable { get; set; }

        [JsonProperty("tool_id")]
        public AlertMessage ToolId { get; set; }

        [JsonProperty("alert_play_audio")]
        public AlertMessage AlertPlayAudio { get; set; }

        [JsonProperty("alert_mta_currency")]
        public AlertMessage AlertMtaCurrency { get; set; }

        [JsonProperty("alert_mta_defaults")]
        public AlertMessage AlertMtaDefaults { get; set; }

        [JsonProperty("time_zone")]
        public AlertMessage TimeZone { get; set; }

        [JsonProperty("alert_default_type")]
        public AlertMessage AlertDefaultType { get; set; }

        [JsonProperty("condition_size")]
        public AlertMessage ConditionSize { get; set; }

        [JsonProperty("condition_outside_rth")]
        public AlertMessage ConditionOutsideRth { get; set; }

        [JsonProperty("conditions")]
        public FluffyConditions Conditions { get; set; }
    }
}
