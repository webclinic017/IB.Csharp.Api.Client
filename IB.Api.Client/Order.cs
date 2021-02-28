namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Order
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public OrderProperties Properties { get; set; }
    }
}
