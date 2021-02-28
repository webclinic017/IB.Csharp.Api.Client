namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class HilariousResponses
    {
        [JsonProperty("200")]
        public Hilarious200 The200 { get; set; }
    }
}
