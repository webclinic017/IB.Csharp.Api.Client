using Newtonsoft.Json;

namespace IB.Api.Client.Model
{
    public class LedgerItem
    {
        [JsonProperty("commoditymarketvalue")]
        public long Commoditymarketvalue { get; set; }

        [JsonProperty("futuremarketvalue")]
        public long Futuremarketvalue { get; set; }

        [JsonProperty("settledcash")]
        public double Settledcash { get; set; }

        [JsonProperty("exchangerate")]
        public double Exchangerate { get; set; }

        [JsonProperty("sessionid")]
        public long Sessionid { get; set; }

        [JsonProperty("cashbalance")]
        public double Cashbalance { get; set; }

        [JsonProperty("corporatebondsmarketvalue")]
        public long Corporatebondsmarketvalue { get; set; }

        [JsonProperty("warrantsmarketvalue")]
        public long Warrantsmarketvalue { get; set; }

        [JsonProperty("netliquidationvalue")]
        public double Netliquidationvalue { get; set; }

        [JsonProperty("interest")]
        public long Interest { get; set; }

        [JsonProperty("unrealizedpnl")]
        public long Unrealizedpnl { get; set; }

        [JsonProperty("stockmarketvalue")]
        public long Stockmarketvalue { get; set; }

        [JsonProperty("moneyfunds")]
        public long Moneyfunds { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("realizedpnl")]
        public long Realizedpnl { get; set; }

        [JsonProperty("funds")]
        public long Funds { get; set; }

        [JsonProperty("acctcode")]
        public string Acctcode { get; set; }

        [JsonProperty("issueroptionsmarketvalue")]
        public long Issueroptionsmarketvalue { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("severity")]
        public long Severity { get; set; }

        [JsonProperty("stockoptionmarketvalue")]
        public long Stockoptionmarketvalue { get; set; }

        [JsonProperty("tbondsmarketvalue")]
        public long Tbondsmarketvalue { get; set; }

        [JsonProperty("futureoptionmarketvalue")]
        public long Futureoptionmarketvalue { get; set; }

        [JsonProperty("cashbalancefxsegment")]
        public long Cashbalancefxsegment { get; set; }

        [JsonProperty("secondkey")]
        public string Secondkey { get; set; }

        [JsonProperty("tbillsmarketvalue")]
        public long Tbillsmarketvalue { get; set; }

        [JsonProperty("dividends")]
        public long Dividends { get; set; }

        [JsonProperty("endofbundle", NullValueHandling = NullValueHandling.Ignore)]
        public long? Endofbundle { get; set; }
    }
}
