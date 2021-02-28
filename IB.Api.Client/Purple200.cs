namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Purple200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public PurpleSchema Schema { get; set; }
    }
}
