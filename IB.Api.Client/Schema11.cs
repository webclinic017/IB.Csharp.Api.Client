namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema11
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public CunningItems Items { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Properties43 Properties { get; set; }
    }
}
