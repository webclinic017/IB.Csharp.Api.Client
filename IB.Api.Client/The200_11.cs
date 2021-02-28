namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_11
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema17 Schema { get; set; }
    }
}
