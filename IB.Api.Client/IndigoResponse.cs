namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndigoResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema14 Schema { get; set; }
    }
}
