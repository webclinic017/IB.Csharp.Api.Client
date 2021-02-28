namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class IndsItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public MischievousProperties Properties { get; set; }
    }
}
