namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class CqtTypes
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public CqtTypesItems Items { get; set; }
    }
}
