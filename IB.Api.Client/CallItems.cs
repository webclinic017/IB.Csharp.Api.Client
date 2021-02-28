namespace IB.Api.Client
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class CallItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("example")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Example { get; set; }
    }
}
