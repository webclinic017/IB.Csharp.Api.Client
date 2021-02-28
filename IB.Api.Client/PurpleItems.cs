namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleItems
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public PurpleProperties Properties { get; set; }
    }
}
