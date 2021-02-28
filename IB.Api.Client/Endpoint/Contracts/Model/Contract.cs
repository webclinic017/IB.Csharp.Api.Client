using System.Collections.Generic;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Contracts.Model
{
    public class Contract
    {
        [JsonProperty("conid")]
        public long Conid { get; set; }

        [JsonProperty("companyHeader")]
        public string CompanyHeader { get; set; }

        [JsonProperty("companyName")]
        public object CompanyName { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("restricted")]
        public object Restricted { get; set; }

        [JsonProperty("fop")]
        public object Fop { get; set; }

        [JsonProperty("opt")]
        public object Opt { get; set; }

        [JsonProperty("war")]
        public object War { get; set; }

        [JsonProperty("sections")]
        public List<Section> Sections { get; set; }
    }
}

