namespace IB.Api.Client
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class Welcome
    {
        [JsonProperty("basePath")]
        public string BasePath { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("produces")]
        public List<string> Produces { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("schemes")]
        public List<string> Schemes { get; set; }

        [JsonProperty("swagger")]
        public string Swagger { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("paths")]
        public Paths Paths { get; set; }

        [JsonProperty("definitions")]
        public Definitions Definitions { get; set; }
    }
}
