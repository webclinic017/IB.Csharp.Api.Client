namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Ambitious200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public AmbitiousSchema Schema { get; set; }
    }
}
