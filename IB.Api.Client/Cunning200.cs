namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Cunning200
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public CunningSchema Schema { get; set; }
    }
}
