namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties5
    {
        [JsonProperty("instruments")]
        public AlertMessage Instruments { get; set; }

        [JsonProperty("displayName")]
        public AccountAlias DisplayName { get; set; }

        [JsonProperty("scanCode")]
        public AlertMessage ScanCode { get; set; }
    }
}
