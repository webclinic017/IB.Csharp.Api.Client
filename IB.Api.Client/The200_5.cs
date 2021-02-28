namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_5
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema5 Schema { get; set; }
    }
}
