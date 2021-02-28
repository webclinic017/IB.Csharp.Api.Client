namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TentacledProperties
    {
        [JsonProperty("assetClass")]
        public PurpleAssetClass AssetClass { get; set; }

        [JsonProperty("sector")]
        public Sector Sector { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }
    }
}
