namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Mischievous200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public BraggadociousSchema Schema { get; set; }
    }
}
