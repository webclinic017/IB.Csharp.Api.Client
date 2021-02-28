namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IserverScannerParams
    {
        [JsonProperty("get")]
        public IserverScannerParamsGet Get { get; set; }
    }
}
