namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class BalanceByDate
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public BalanceByDateProperties Properties { get; set; }
    }
}
