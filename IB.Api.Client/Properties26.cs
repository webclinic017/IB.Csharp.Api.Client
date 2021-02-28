namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties26
    {
        [JsonProperty("order_id")]
        public AccountAlias OrderId { get; set; }

        [JsonProperty("account")]
        public AlertMessage Account { get; set; }

        [JsonProperty("alert_name")]
        public AccountAlias AlertName { get; set; }

        [JsonProperty("alert_active")]
        public AlertMessage AlertActive { get; set; }

        [JsonProperty("order_time")]
        public AlertMessage OrderTime { get; set; }

        [JsonProperty("alert_triggered")]
        public AlertMessage AlertTriggered { get; set; }

        [JsonProperty("alert_repeatable")]
        public AlertMessage AlertRepeatable { get; set; }
    }
}
