namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ScanTypeListProperties
    {
        [JsonProperty("ScanType")]
        public ScanType ScanType { get; set; }
    }
}
