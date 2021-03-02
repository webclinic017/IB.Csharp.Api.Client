using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Orders.Request
{
    public class OrderReplyRequest
    {
        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }
    }
}
