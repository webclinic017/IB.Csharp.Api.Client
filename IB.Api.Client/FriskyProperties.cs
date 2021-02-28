namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FriskyProperties
    {
        [JsonProperty("o")]
        public AlertMessage O { get; set; }

        [JsonProperty("c")]
        public AlertMessage C { get; set; }

        [JsonProperty("h")]
        public AlertMessage H { get; set; }

        [JsonProperty("l")]
        public AlertMessage L { get; set; }

        [JsonProperty("v")]
        public AlertMessage V { get; set; }

        [JsonProperty("t")]
        public AlertMessage T { get; set; }
    }
}
