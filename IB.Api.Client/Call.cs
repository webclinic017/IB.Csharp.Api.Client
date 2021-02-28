namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Call
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public CallItems Items { get; set; }
    }
}
