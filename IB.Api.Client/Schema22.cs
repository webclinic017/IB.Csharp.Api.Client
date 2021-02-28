namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Schema22
    {
        [JsonProperty("type")]
        public AccountAliasType Type { get; set; }

        [JsonProperty("properties")]
        public Properties58 Properties { get; set; }
    }
}
