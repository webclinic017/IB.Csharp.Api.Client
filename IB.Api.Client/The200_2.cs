namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class The200_2
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Accounts Schema { get; set; }
    }
}
