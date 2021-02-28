namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleResponses
    {
        [JsonProperty("200")]
        public Purple200 The200 { get; set; }
    }
}
