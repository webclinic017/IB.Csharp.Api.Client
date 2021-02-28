namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverAccountOrders
    {
        [JsonProperty("get")]
        public IserverAccountOrdersGet Get { get; set; }
    }
}
