using System.Collections.Generic;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Portfolio.Model
{
    public class Position
    {
        [JsonProperty("acctId")]
        public string AcctId { get; set; }

        [JsonProperty("conid")]
        public string Conid { get; set; }

        [JsonProperty("contractDesc")]
        public string ContractDesc { get; set; }

        [JsonProperty("assetClass")]
        public string AssetClass { get; set; }

        [JsonProperty("position")]
        public long PositionValue { get; set; }

        [JsonProperty("mktPrice")]
        public string MktPrice { get; set; }

        [JsonProperty("mktValue")]
        public string MktValue { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("avgCost")]
        public string AvgCost { get; set; }

        [JsonProperty("avgPrice")]
        public string AvgPrice { get; set; }

        [JsonProperty("realizedPnl")]
        public string RealizedPnl { get; set; }

        [JsonProperty("unrealizedPnl")]
        public string UnrealizedPnl { get; set; }

        [JsonProperty("exchs")]
        public string Exchs { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("putOrCall")]
        public string PutOrCall { get; set; }

        [JsonProperty("multiplier")]
        public string Multiplier { get; set; }

        [JsonProperty("strike")]
        public string Strike { get; set; }

        [JsonProperty("exerciseStyle")]
        public string ExerciseStyle { get; set; }

        [JsonProperty("undConid")]
        public string UndConid { get; set; }

        [JsonProperty("conExchMap")]
        public List<string> ConExchMap { get; set; }

        [JsonProperty("baseMktValue")]
        public string BaseMktValue { get; set; }

        [JsonProperty("baseMktPrice")]
        public string BaseMktPrice { get; set; }

        [JsonProperty("baseAvgCost")]
        public string BaseAvgCost { get; set; }

        [JsonProperty("baseAvgPrice")]
        public string BaseAvgPrice { get; set; }

        [JsonProperty("baseRealizedPnl")]
        public string BaseRealizedPnl { get; set; }

        [JsonProperty("baseUnrealizedPnl")]
        public string BaseUnrealizedPnl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastTradingDay")]
        public string LastTradingDay { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("sector")]
        public string Sector { get; set; }

        [JsonProperty("sectorGroup")]
        public string SectorGroup { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("undComp")]
        public string UndComp { get; set; }

        [JsonProperty("undSym")]
        public string UndSym { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }
    }
}
