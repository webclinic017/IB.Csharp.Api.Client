namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AmountProperties
    {
        [JsonProperty("amount")]
        public AlertMessage Amount { get; set; }

        [JsonProperty("commission")]
        public AlertMessage Commission { get; set; }

        [JsonProperty("total")]
        public AccountAlias Total { get; set; }
    }
}
