namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_8
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema10 Schema { get; set; }
    }
}
