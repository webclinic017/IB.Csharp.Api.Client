namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PropertiesTransactions
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public TransactionsItems Items { get; set; }
    }
}
