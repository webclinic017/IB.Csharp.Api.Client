namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Indigo200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public ItemsValue Schema { get; set; }
    }
}
