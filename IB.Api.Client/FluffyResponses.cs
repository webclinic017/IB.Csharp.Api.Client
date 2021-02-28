namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyResponses
    {
        [JsonProperty("200")]
        public Fluffy200 The200 { get; set; }
    }
}
