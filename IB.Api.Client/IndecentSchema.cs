namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndecentSchema
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public IndigoItems Items { get; set; }
    }
}
