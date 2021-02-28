namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SectorProperties
    {
        [JsonProperty("long")]
        public FluffyLong Long { get; set; }

        [JsonProperty("short")]
        public FluffyShort Short { get; set; }
    }
}
