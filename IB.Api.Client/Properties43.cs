namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties43
    {
        [JsonProperty("error")]
        public AlertMessage Error { get; set; }

        [JsonProperty("statusCode")]
        public AccountAlias StatusCode { get; set; }
    }
}
