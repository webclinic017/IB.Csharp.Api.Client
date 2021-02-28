namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndecentResponses
    {
        [JsonProperty("200")]
        public Indecent200 The200 { get; set; }
    }
}
