namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties4
    {
        [JsonProperty("instruments")]
        public AccountAlias Instruments { get; set; }

        [JsonProperty("displayName")]
        public AccountAlias DisplayName { get; set; }

        [JsonProperty("locationCode")]
        public AccountAlias LocationCode { get; set; }

        [JsonProperty("routeExchange")]
        public AccountAlias RouteExchange { get; set; }
    }
}
