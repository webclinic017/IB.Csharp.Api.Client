namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FyiSettingsTypecode
    {
        [JsonProperty("post")]
        public FyiSettingsTypecodePost Post { get; set; }
    }
}
