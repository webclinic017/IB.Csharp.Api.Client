namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AccountAlias
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }
    }
}
