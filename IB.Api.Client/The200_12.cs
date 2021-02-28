namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_12
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema18 Schema { get; set; }
    }
}
