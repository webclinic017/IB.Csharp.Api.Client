namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties8
    {
        [JsonProperty("conid")]
        public AlertMessage Conid { get; set; }

        [JsonProperty("exchange")]
        public AssetClass Exchange { get; set; }
    }
}
