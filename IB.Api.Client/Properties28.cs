namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties28
    {
        [JsonProperty("orders")]
        public FluffyOrders Orders { get; set; }

        [JsonProperty("snapshot")]
        public AlertMessage Snapshot { get; set; }
    }
}
