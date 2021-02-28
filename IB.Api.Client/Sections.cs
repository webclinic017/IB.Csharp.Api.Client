namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Sections
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public SectionsItems Items { get; set; }
    }
}
