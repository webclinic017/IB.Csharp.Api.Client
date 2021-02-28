namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ScannerParamsProperties
    {
        [JsonProperty("InstrumentList")]
        public InstrumentList InstrumentList { get; set; }

        [JsonProperty("LocationTree")]
        public LocationTree LocationTree { get; set; }

        [JsonProperty("FilterList")]
        public FilterListClass FilterList { get; set; }

        [JsonProperty("ScanTypeList")]
        public ScanTypeList ScanTypeList { get; set; }
    }
}
