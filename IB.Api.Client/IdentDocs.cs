namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IdentDocs
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public IdentDocsItems Items { get; set; }
    }
}
