namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class StickyResponses
    {
        [JsonProperty("200")]
        public Sticky200 The200 { get; set; }
    }
}
