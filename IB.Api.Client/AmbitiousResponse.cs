namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AmbitiousResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public Schema20 Schema { get; set; }
    }
}
