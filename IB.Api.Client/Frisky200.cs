namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Frisky200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public FriskySchema Schema { get; set; }
    }
}
