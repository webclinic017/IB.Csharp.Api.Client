namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties35
    {
        [JsonProperty("cfi_code")]
        public AlertMessage CfiCode { get; set; }

        [JsonProperty("symbol")]
        public AlertMessage Symbol { get; set; }

        [JsonProperty("cusip")]
        public AccountAlias Cusip { get; set; }

        [JsonProperty("expiry_full")]
        public AlertMessage ExpiryFull { get; set; }

        [JsonProperty("con_id")]
        public AlertMessage ConId { get; set; }

        [JsonProperty("maturity_date")]
        public AlertMessage MaturityDate { get; set; }

        [JsonProperty("industry")]
        public AlertMessage Industry { get; set; }

        [JsonProperty("instrument_type")]
        public AlertMessage InstrumentType { get; set; }

        [JsonProperty("trading_class")]
        public AlertMessage TradingClass { get; set; }

        [JsonProperty("valid_exchanges")]
        public AlertMessage ValidExchanges { get; set; }

        [JsonProperty("allow_sell_long")]
        public AlertMessage AllowSellLong { get; set; }

        [JsonProperty("is_zero_commission_security")]
        public AlertMessage IsZeroCommissionSecurity { get; set; }

        [JsonProperty("local_symbol")]
        public AlertMessage LocalSymbol { get; set; }

        [JsonProperty("classifier")]
        public AccountAlias Classifier { get; set; }

        [JsonProperty("currency")]
        public AlertMessage Currency { get; set; }

        [JsonProperty("text")]
        public AlertMessage Text { get; set; }

        [JsonProperty("underlying_con_id")]
        public AlertMessage UnderlyingConId { get; set; }

        [JsonProperty("r_t_h")]
        public AlertMessage RTH { get; set; }

        [JsonProperty("multiplier")]
        public AlertMessage Multiplier { get; set; }

        [JsonProperty("strike")]
        public AlertMessage Strike { get; set; }

        [JsonProperty("right")]
        public AlertMessage Right { get; set; }

        [JsonProperty("underlying_issuer")]
        public AlertMessage UnderlyingIssuer { get; set; }

        [JsonProperty("contract_month")]
        public AlertMessage ContractMonth { get; set; }

        [JsonProperty("company_name")]
        public AlertMessage CompanyName { get; set; }

        [JsonProperty("smart_available")]
        public AlertMessage SmartAvailable { get; set; }

        [JsonProperty("exchange")]
        public AlertMessage Exchange { get; set; }

        [JsonProperty("rules")]
        public FluffyRules Rules { get; set; }
    }
}
