namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties16
    {
        [JsonProperty("T")]
        public AccountAlias T { get; set; }

        [JsonProperty("V")]
        public AccountAlias V { get; set; }
    }
}
