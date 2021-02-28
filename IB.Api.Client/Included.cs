namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Included
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public AlertMessage Items { get; set; }
    }
}
