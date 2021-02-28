namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_6
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema6 Schema { get; set; }
    }
}
