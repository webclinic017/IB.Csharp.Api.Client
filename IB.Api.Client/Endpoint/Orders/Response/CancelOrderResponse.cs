using System;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Orders.Response
{
    public class CancelOrderResponse
    {
        [JsonProperty("order_id")]
        public Guid Id { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("conId")]
        public long ContractId{ get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }
    }
}
