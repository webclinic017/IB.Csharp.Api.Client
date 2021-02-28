namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class LocationTreeClass
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public LocationTreeItems Items { get; set; }
    }
}
