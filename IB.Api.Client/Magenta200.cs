namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Magenta200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public MagentaSchema Schema { get; set; }
    }
}
