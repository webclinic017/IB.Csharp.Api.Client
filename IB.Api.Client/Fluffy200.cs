namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Fluffy200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public TentacledSchema Schema { get; set; }
    }
}
