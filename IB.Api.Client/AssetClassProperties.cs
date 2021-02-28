namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AssetClassProperties
    {
        [JsonProperty("long")]
        public ShortClass Long { get; set; }

        [JsonProperty("short")]
        public ShortClass Short { get; set; }
    }
}
