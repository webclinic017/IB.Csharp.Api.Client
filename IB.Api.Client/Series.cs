namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Series
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public SeriesItems Items { get; set; }
    }
}
