using Newtonsoft.Json;

namespace IB.Api.Client.Model
{
    public class Account
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("accountVan")]
        public string AccountVan { get; set; }

        [JsonProperty("accountTitle")]
        public string AccountTitle { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("accountAlias")]
        public string AccountAlias { get; set; }

        [JsonProperty("accountStatus")]
        public long AccountStatus { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tradingType")]
        public string TradingType { get; set; }

        [JsonProperty("faclient")]
        public bool Faclient { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("covestor")]
        public bool Covestor { get; set; }

        [JsonProperty("master")]
        public Master Master { get; set; }
    }
}
