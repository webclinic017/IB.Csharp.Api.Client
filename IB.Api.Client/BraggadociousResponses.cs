namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class BraggadociousResponses
    {
        [JsonProperty("200")]
        public Braggadocious200 The200 { get; set; }
    }
}
