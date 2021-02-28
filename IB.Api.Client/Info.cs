namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Info
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
