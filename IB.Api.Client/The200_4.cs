namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_4
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema4 Schema { get; set; }
    }
}
