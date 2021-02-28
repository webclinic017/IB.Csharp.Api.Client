namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Sticky200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public StickySchema Schema { get; set; }
    }
}
