namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_9
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema12 Schema { get; set; }
    }
}
