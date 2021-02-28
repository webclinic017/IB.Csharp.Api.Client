namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Indecent200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public IndecentSchema Schema { get; set; }
    }
}
