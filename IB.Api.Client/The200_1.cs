namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_1
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema2 Schema { get; set; }
    }
}
