namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MischievousResponses
    {
        [JsonProperty("200")]
        public Mischievous200 The200 { get; set; }
    }
}
