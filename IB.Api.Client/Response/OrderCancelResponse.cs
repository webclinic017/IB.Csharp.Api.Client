using Newtonsoft.Json;

namespace IB.Api.Client.Response
{
    public class OrderCancelResponse
    {
        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("conid")]
        public long Conid { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }
    }
}