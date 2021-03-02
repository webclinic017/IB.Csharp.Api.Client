using System;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Orders.Model
{
    public class OrderReply
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_status")]
        public string Status { get; set; }

        [JsonProperty("local_order_id")]
        public bool LocalOrderId { get; set; }
    }
}
