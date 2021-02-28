namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties25
    {
        [JsonProperty("request_id")]
        public AccountAlias RequestId { get; set; }

        [JsonProperty("order_id")]
        public AccountAlias OrderId { get; set; }

        [JsonProperty("success")]
        public AccountAlias Success { get; set; }

        [JsonProperty("text")]
        public AccountAlias Text { get; set; }

        [JsonProperty("order_status")]
        public AccountAlias OrderStatus { get; set; }

        [JsonProperty("failure_list", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAlias FailureList { get; set; }

        [JsonProperty("warning_message", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAlias WarningMessage { get; set; }
    }
}
