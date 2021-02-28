namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class CunningResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema21 Schema { get; set; }
    }
}
