namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndigoResponses
    {
        [JsonProperty("200")]
        public Indigo200 The200 { get; set; }
    }
}
