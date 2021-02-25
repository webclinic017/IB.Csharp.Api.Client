using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IB.Api.Client.Model
{
    public class OrderConfirmation
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("message")]
        public List<string> Message { get; set; }

        [JsonProperty("isSuppressed")]
        public bool IsSuppressed { get; set; }

        [JsonProperty("messageIds")]
        public List<string> MessageIds { get; set; }
    }
}
