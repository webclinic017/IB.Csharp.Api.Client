namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties44
    {
        [JsonProperty("scan_type_list")]
        public ScanTypeListClass ScanTypeList { get; set; }

        [JsonProperty("instrument_list")]
        public InstrumentListClass InstrumentList { get; set; }

        [JsonProperty("filter_list")]
        public PropertiesFilterList FilterList { get; set; }

        [JsonProperty("location_tree")]
        public LocationTreeClass LocationTree { get; set; }
    }
}
