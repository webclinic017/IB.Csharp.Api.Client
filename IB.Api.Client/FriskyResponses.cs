namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FriskyResponses
    {
        [JsonProperty("200")]
        public Frisky200 The200 { get; set; }
    }
}
