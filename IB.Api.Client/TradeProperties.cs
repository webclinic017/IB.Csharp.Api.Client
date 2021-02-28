namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class TradeProperties
    {
        [JsonProperty("execution_id")]
        public AccountAlias ExecutionId { get; set; }

        [JsonProperty("symbol")]
        public AccountAlias Symbol { get; set; }

        [JsonProperty("side")]
        public AccountAlias Side { get; set; }

        [JsonProperty("order_description")]
        public AccountAlias OrderDescription { get; set; }

        [JsonProperty("trade_time")]
        public AccountAlias TradeTime { get; set; }

        [JsonProperty("trade_time_r")]
        public AccountAlias TradeTimeR { get; set; }

        [JsonProperty("size")]
        public AccountAlias Size { get; set; }

        [JsonProperty("price")]
        public AccountAlias Price { get; set; }

        [JsonProperty("submitter")]
        public AccountAlias Submitter { get; set; }

        [JsonProperty("exchange")]
        public AccountAlias Exchange { get; set; }

        [JsonProperty("comission")]
        public AccountAlias Comission { get; set; }

        [JsonProperty("net_amount")]
        public AccountAlias NetAmount { get; set; }

        [JsonProperty("account")]
        public AccountAlias Account { get; set; }

        [JsonProperty("company_name")]
        public AccountAlias CompanyName { get; set; }

        [JsonProperty("contract_description_1")]
        public AccountAlias ContractDescription1 { get; set; }

        [JsonProperty("sec_type")]
        public AccountAlias SecType { get; set; }

        [JsonProperty("conidex")]
        public AccountAlias Conidex { get; set; }

        [JsonProperty("position")]
        public AccountAlias Position { get; set; }

        [JsonProperty("clearing_id")]
        public AccountAlias ClearingId { get; set; }

        [JsonProperty("clearing_name")]
        public AccountAlias ClearingName { get; set; }

        [JsonProperty("order_ref")]
        public AlertMessage OrderRef { get; set; }
    }
}
