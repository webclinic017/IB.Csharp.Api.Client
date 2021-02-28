namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_3
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema3 Schema { get; set; }
    }
}
