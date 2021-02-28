namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverScannerRun
    {
        [JsonProperty("post")]
        public IserverScannerRunPost Post { get; set; }
    }
}
