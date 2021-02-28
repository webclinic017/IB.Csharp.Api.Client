namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Position
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public PositionItems Items { get; set; }
    }
}
