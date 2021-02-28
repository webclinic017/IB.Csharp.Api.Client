namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema9
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public MagentaItems Items { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Properties41 Properties { get; set; }
    }
}
