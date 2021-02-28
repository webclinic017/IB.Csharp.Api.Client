namespace IB.Api.Client
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class Freq
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("enum")]
        public List<string> Enum { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
