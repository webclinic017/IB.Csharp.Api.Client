namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_13
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema19 Schema { get; set; }
    }
}
