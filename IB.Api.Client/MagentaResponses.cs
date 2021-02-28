namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MagentaResponses
    {
        [JsonProperty("200")]
        public Magenta200 The200 { get; set; }
    }
}
