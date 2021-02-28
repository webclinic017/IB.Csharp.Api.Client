namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties53
    {
        [JsonProperty("call", NullValueHandling = NullValueHandling.Ignore)]
        public Call Call { get; set; }

        [JsonProperty("put", NullValueHandling = NullValueHandling.Ignore)]
        public Call Put { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public AccountAlias Error { get; set; }
    }
}
