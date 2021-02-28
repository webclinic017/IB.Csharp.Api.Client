namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FluffyDate
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public ConExchMap Items { get; set; }
    }
}
