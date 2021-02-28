namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ScanTypeListClass
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public ScanTypeListItems Items { get; set; }
    }
}
