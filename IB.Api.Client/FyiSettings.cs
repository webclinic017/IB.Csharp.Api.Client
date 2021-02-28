namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FyiSettings
    {
        [JsonProperty("get")]
        public FyiSettingsGet Get { get; set; }
    }
}
