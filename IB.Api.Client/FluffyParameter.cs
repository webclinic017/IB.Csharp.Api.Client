namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyParameter
    {
        [JsonProperty("in")]
        public In In { get; set; }

        [JsonProperty("name")]
        public In Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public MischievousSchema Schema { get; set; }
    }
}
