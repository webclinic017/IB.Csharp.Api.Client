namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Accounts
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public ItemsValue Items { get; set; }
    }
}
