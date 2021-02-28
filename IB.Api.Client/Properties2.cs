namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties2
    {
        [JsonProperty("acctId")]
        public AccountAlias AcctId { get; set; }

        [JsonProperty("conid")]
        public AccountAlias Conid { get; set; }

        [JsonProperty("contractDesc")]
        public AccountAlias ContractDesc { get; set; }

        [JsonProperty("assetClass")]
        public AccountAlias AssetClass { get; set; }

        [JsonProperty("position")]
        public AccountAlias Position { get; set; }

        [JsonProperty("mktPrice")]
        public AccountAlias MktPrice { get; set; }

        [JsonProperty("mktValue")]
        public AccountAlias MktValue { get; set; }

        [JsonProperty("currency")]
        public AccountAlias Currency { get; set; }

        [JsonProperty("avgCost")]
        public AccountAlias AvgCost { get; set; }

        [JsonProperty("avgPrice")]
        public AccountAlias AvgPrice { get; set; }

        [JsonProperty("realizedPnl")]
        public AccountAlias RealizedPnl { get; set; }

        [JsonProperty("unrealizedPnl")]
        public AccountAlias UnrealizedPnl { get; set; }

        [JsonProperty("exchs")]
        public AccountAlias Exchs { get; set; }

        [JsonProperty("expiry")]
        public AccountAlias Expiry { get; set; }

        [JsonProperty("putOrCall")]
        public AccountAlias PutOrCall { get; set; }

        [JsonProperty("multiplier")]
        public AccountAlias Multiplier { get; set; }

        [JsonProperty("strike")]
        public AccountAlias Strike { get; set; }

        [JsonProperty("exerciseStyle")]
        public AccountAlias ExerciseStyle { get; set; }

        [JsonProperty("undConid")]
        public AccountAlias UndConid { get; set; }

        [JsonProperty("conExchMap")]
        public ConExchMap ConExchMap { get; set; }

        [JsonProperty("baseMktValue")]
        public AccountAlias BaseMktValue { get; set; }

        [JsonProperty("baseMktPrice")]
        public AccountAlias BaseMktPrice { get; set; }

        [JsonProperty("baseAvgCost")]
        public AccountAlias BaseAvgCost { get; set; }

        [JsonProperty("baseAvgPrice")]
        public AccountAlias BaseAvgPrice { get; set; }

        [JsonProperty("baseRealizedPnl")]
        public AccountAlias BaseRealizedPnl { get; set; }

        [JsonProperty("baseUnrealizedPnl")]
        public AccountAlias BaseUnrealizedPnl { get; set; }

        [JsonProperty("name")]
        public AccountAlias Name { get; set; }

        [JsonProperty("lastTradingDay")]
        public AccountAlias LastTradingDay { get; set; }

        [JsonProperty("group")]
        public AccountAlias Group { get; set; }

        [JsonProperty("sector")]
        public AccountAlias Sector { get; set; }

        [JsonProperty("sectorGroup")]
        public AccountAlias SectorGroup { get; set; }

        [JsonProperty("ticker")]
        public AccountAlias Ticker { get; set; }

        [JsonProperty("undComp")]
        public AccountAlias UndComp { get; set; }

        [JsonProperty("undSym")]
        public AccountAlias UndSym { get; set; }

        [JsonProperty("fullName")]
        public AccountAlias FullName { get; set; }

        [JsonProperty("pageSize")]
        public AccountAlias PageSize { get; set; }

        [JsonProperty("model")]
        public AccountAlias Model { get; set; }
    }
}
