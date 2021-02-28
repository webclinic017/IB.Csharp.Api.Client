namespace IB.Api.Client
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class IserverAccountPnlPartitionedGet
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("responses")]
        public Responses1 Responses { get; set; }
    }
}
