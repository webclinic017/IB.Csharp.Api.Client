namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class E
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public EItems Items { get; set; }
    }
}
