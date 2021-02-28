namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SystemErrorProperties
    {
        [JsonProperty("error")]
        public AccountAlias Error { get; set; }
    }
}
