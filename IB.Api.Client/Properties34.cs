namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties34
    {
        [JsonProperty("accounts")]
        public Prompts Accounts { get; set; }

        [JsonProperty("aliases")]
        public AlertMessage Aliases { get; set; }

        [JsonProperty("selectedAccount")]
        public AccountAlias SelectedAccount { get; set; }
    }
}
