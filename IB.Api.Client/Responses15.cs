namespace IB.Api.Client
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Responses15
    {
        [JsonProperty("200")]
        public The200_15 The200 { get; set; }
    }
}
