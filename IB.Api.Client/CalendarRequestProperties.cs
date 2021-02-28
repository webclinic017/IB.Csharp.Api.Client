namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class CalendarRequestProperties
    {
        [JsonProperty("date")]
        public PurpleDate Date { get; set; }

        [JsonProperty("filters")]
        public OrderRequest Filters { get; set; }
    }
}
