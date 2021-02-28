namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ScanType
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public ScanTypeItems Items { get; set; }
    }
}
