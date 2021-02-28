namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TransactionsProperties
    {
        [JsonProperty("id")]
        public AlertMessage Id { get; set; }

        [JsonProperty("currency")]
        public AlertMessage Currency { get; set; }

        [JsonProperty("includesRealTime")]
        public AlertMessage IncludesRealTime { get; set; }

        [JsonProperty("from")]
        public AlertMessage From { get; set; }

        [JsonProperty("to")]
        public AlertMessage To { get; set; }

        [JsonProperty("transactions")]
        public PropertiesTransactions Transactions { get; set; }
    }
}
