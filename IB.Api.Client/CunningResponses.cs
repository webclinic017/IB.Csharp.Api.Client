namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class CunningResponses
    {
        [JsonProperty("200")]
        public Cunning200 The200 { get; set; }
    }
}
