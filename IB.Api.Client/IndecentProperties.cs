namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndecentProperties
    {
        [JsonProperty("Banks")]
        public AccountAlias Banks { get; set; }

        [JsonProperty("Airlines")]
        public AccountAlias Airlines { get; set; }

        [JsonProperty("Internet")]
        public AccountAlias Internet { get; set; }
    }
}
