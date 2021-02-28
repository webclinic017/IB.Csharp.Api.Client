namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties50
    {
        [JsonProperty("server_id")]
        public AccountAlias ServerId { get; set; }

        [JsonProperty("column_name")]
        public AccountAlias ColumnName { get; set; }

        [JsonProperty("symbol")]
        public AccountAlias Symbol { get; set; }

        [JsonProperty("conidex")]
        public AccountAlias Conidex { get; set; }

        [JsonProperty("con_id")]
        public AccountAlias ConId { get; set; }

        [JsonProperty("available_chart_periods")]
        public AccountAlias AvailableChartPeriods { get; set; }

        [JsonProperty("company_name")]
        public AccountAlias CompanyName { get; set; }

        [JsonProperty("contract_description_1")]
        public AccountAlias ContractDescription1 { get; set; }

        [JsonProperty("listing_exchange")]
        public AccountAlias ListingExchange { get; set; }

        [JsonProperty("sec_type")]
        public AccountAlias SecType { get; set; }
    }
}
