namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyOrders
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public OrderRequest Items { get; set; }
    }
}
