namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_7
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema7 Schema { get; set; }
    }
}
