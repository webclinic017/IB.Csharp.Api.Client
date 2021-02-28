namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties12
    {
        [JsonProperty("conid")]
        public AccountAlias Conid { get; set; }

        [JsonProperty("curr")]
        public AccountAlias Curr { get; set; }

        [JsonProperty("desc")]
        public AccountAlias Desc { get; set; }

        [JsonProperty("part")]
        public AccountAlias Part { get; set; }
    }
}
