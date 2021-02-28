using System.Collections.Generic;
using IB.Api.Client.Endpoint.Orders.Model;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Orders.Response
{
    public class OrdersResponse
    {
        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }

        [JsonProperty("snapshot")]
        public bool Snapshot { get; set; }
    }
}