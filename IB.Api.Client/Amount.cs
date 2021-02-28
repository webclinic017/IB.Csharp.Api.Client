namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Amount
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public AmountProperties Properties { get; set; }
    }
}
