namespace IB.Api.Client
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class IserverContractConidInfoAndRulesGet
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("parameters")]
        public List<PutParameter> Parameters { get; set; }

        [JsonProperty("responses")]
        public Responses7 Responses { get; set; }
    }
}
