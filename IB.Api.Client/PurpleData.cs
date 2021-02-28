namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PurpleData
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public TentacledItems Items { get; set; }
    }
}
