using System.Collections.Generic;
using Newtonsoft.Json;

namespace IB.Api.Client.Streaming
{
    public partial class MessageFields
    {
        [JsonProperty("fields")]
        public List<string> Fields { get; set; }
    }
}