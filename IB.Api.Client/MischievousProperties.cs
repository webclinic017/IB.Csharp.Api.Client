namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MischievousProperties
    {
        [JsonProperty("conid")]
        public AccountAlias Conid { get; set; }
    }
}
