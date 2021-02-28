namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema15
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public MischievousItems Items { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public SystemErrorProperties Properties { get; set; }
    }
}
