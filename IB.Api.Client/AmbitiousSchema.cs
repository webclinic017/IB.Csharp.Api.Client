namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AmbitiousSchema
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public IndecentItems Items { get; set; }
    }
}
