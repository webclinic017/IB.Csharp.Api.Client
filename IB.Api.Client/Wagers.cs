namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Wagers
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public WagersItems Items { get; set; }
    }
}
