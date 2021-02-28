namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_10
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema13 Schema { get; set; }
    }
}
