namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AmbitiousResponses
    {
        [JsonProperty("200")]
        public Ambitious200 The200 { get; set; }
    }
}
