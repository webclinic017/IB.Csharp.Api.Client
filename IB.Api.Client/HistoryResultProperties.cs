namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class HistoryResultProperties
    {
        [JsonProperty("bars")]
        public Bars Bars { get; set; }
    }
}
