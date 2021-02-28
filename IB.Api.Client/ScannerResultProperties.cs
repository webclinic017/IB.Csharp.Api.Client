namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ScannerResultProperties
    {
        [JsonProperty("total")]
        public AccountAlias Total { get; set; }

        [JsonProperty("size")]
        public AccountAlias Size { get; set; }

        [JsonProperty("offset")]
        public AccountAlias Offset { get; set; }

        [JsonProperty("scanTime")]
        public AccountAlias ScanTime { get; set; }

        [JsonProperty("id")]
        public AccountAlias Id { get; set; }

        [JsonProperty("position")]
        public AccountAlias Position { get; set; }

        [JsonProperty("Contracts")]
        public Contracts Contracts { get; set; }
    }
}
