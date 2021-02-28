namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TentacledResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public Schema10 Schema { get; set; }
    }
}
