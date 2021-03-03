using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Trades.Model
{
    public class Trade
    {
        [JsonProperty("execution_id")]
        public string ExecutionId { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("order_description")]
        public string OrderDescription { get; set; }

        [JsonProperty("trade_time")]
        public string TradeTime { get; set; }

        [JsonProperty("trade_time_r")]
        public string TradeTimeR { get; set; }

        [JsonProperty("size")]
        public double Size { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("submitter")]
        public string Submitter { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("comission")]
        public double Comission { get; set; }

        [JsonProperty("net_amount")]
        public long NetAmount { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contract_description_1")]
        public string ContractDescription1 { get; set; }

        [JsonProperty("sec_type")]
        public string SecType { get; set; }

        [JsonProperty("conidex")]
        public long Conidex { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("clearing_id")]
        public string ClearingId { get; set; }

        [JsonProperty("clearing_name")]
        public string ClearingName { get; set; }
    }
}
