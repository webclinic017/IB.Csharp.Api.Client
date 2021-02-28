namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema9 Schema { get; set; }
    }
}
