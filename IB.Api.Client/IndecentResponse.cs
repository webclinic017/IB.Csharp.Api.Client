namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndecentResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema15 Schema { get; set; }
    }
}
