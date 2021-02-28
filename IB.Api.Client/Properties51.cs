namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties51
    {
        [JsonProperty("conid")]
        public AlertMessage Conid { get; set; }

        [JsonProperty("companyHeader")]
        public AlertMessage CompanyHeader { get; set; }

        [JsonProperty("companyName")]
        public AccountAlias CompanyName { get; set; }

        [JsonProperty("symbol")]
        public AccountAlias Symbol { get; set; }

        [JsonProperty("description")]
        public AlertMessage Description { get; set; }

        [JsonProperty("restricted")]
        public AccountAlias Restricted { get; set; }

        [JsonProperty("fop")]
        public AccountAlias Fop { get; set; }

        [JsonProperty("opt")]
        public AccountAlias Opt { get; set; }

        [JsonProperty("war")]
        public AccountAlias War { get; set; }

        [JsonProperty("sections")]
        public Sections Sections { get; set; }
    }
}
