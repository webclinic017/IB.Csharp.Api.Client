namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ItemsValue
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }
}
