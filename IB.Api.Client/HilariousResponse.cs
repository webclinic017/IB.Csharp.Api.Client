namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class HilariousResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema16 Schema { get; set; }
    }
}
