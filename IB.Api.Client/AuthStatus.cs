namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class AuthStatus
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public AuthStatusProperties Properties { get; set; }
    }
}
