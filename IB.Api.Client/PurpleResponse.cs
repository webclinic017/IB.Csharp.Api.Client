namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema8 Schema { get; set; }
    }
}
