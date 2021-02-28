namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TentacledResponses
    {
        [JsonProperty("200")]
        public Tentacled200 The200 { get; set; }
    }
}
