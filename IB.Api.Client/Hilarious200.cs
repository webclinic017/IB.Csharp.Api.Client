namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Hilarious200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public HilariousSchema Schema { get; set; }
    }
}
