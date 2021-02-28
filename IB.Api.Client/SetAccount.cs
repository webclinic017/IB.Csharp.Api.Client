namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class SetAccount
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public SetAccountProperties Properties { get; set; }
    }
}
