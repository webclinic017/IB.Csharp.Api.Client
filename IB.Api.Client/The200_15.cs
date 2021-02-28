namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_15
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema22 Schema { get; set; }
    }
}
