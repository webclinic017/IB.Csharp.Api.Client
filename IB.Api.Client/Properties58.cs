namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties58
    {
        [JsonProperty("id")]
        public AccountAlias Id { get; set; }

        [JsonProperty("tradeVenueId")]
        public AlertMessage TradeVenueId { get; set; }

        [JsonProperty("schedules")]
        public Schedules Schedules { get; set; }
    }
}
