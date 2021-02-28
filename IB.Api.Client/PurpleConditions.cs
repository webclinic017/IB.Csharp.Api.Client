namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleConditions
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public PurpleItems Items { get; set; }
    }
}
