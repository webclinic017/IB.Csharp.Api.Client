namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class StickyResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema11 Schema { get; set; }
    }
}
