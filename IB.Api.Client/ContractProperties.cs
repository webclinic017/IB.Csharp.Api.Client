namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class ContractProperties
    {
        [JsonProperty("r_t_h")]
        public AlertMessage RTH { get; set; }

        [JsonProperty("con_id")]
        public AlertMessage ConId { get; set; }

        [JsonProperty("company_name")]
        public AccountAlias PropertiesCompanyName { get; set; }

        [JsonProperty("exchange")]
        public AccountAlias Exchange { get; set; }

        [JsonProperty("local_symbol")]
        public AlertMessage LocalSymbol { get; set; }

        [JsonProperty("instrument_type")]
        public AlertMessage InstrumentType { get; set; }

        [JsonProperty("currency")]
        public AccountAlias Currency { get; set; }

        [JsonProperty("companyName")]
        public AccountAlias CompanyName { get; set; }

        [JsonProperty("category")]
        public AccountAlias Category { get; set; }

        [JsonProperty("industry")]
        public AccountAlias Industry { get; set; }

        [JsonProperty("rules")]
        public PurpleRules Rules { get; set; }
    }
}
