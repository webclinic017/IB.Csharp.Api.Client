namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AccountProperties
    {
        [JsonProperty("id")]
        public AccountAlias Id { get; set; }

        [JsonProperty("accountId")]
        public AccountAlias AccountId { get; set; }

        [JsonProperty("accountVan")]
        public AccountAlias AccountVan { get; set; }

        [JsonProperty("accountTitle")]
        public AccountAlias AccountTitle { get; set; }

        [JsonProperty("displayName")]
        public AccountAlias DisplayName { get; set; }

        [JsonProperty("accountAlias")]
        public AccountAlias AccountAlias { get; set; }

        [JsonProperty("accountStatus")]
        public AccountAlias AccountStatus { get; set; }

        [JsonProperty("currency")]
        public AccountAlias Currency { get; set; }

        [JsonProperty("type")]
        public AccountAlias Type { get; set; }

        [JsonProperty("tradingType")]
        public AccountAlias TradingType { get; set; }

        [JsonProperty("faclient")]
        public AccountAlias Faclient { get; set; }

        [JsonProperty("parent")]
        public AccountAlias Parent { get; set; }

        [JsonProperty("desc")]
        public AccountAlias Desc { get; set; }

        [JsonProperty("covestor")]
        public AccountAlias Covestor { get; set; }

        [JsonProperty("master")]
        public Master Master { get; set; }
    }
}
