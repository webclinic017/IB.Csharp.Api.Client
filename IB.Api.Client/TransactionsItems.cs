namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TransactionsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties11 Properties { get; set; }
    }
}
