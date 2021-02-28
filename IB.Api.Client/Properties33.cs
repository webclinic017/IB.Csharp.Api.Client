namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties33
    {
        [JsonProperty("order_id")]
        public AccountAlias OrderId { get; set; }

        [JsonProperty("local_order_id")]
        public AccountAlias LocalOrderId { get; set; }

        [JsonProperty("order_status")]
        public AccountAlias OrderStatus { get; set; }
    }
}
