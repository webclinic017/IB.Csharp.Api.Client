namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Braggadocious200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema1 Schema { get; set; }
    }
}
