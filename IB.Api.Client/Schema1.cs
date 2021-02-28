namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema1
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public AmbitiousItems Items { get; set; }
    }
}
