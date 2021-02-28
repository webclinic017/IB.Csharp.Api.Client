namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class PropertiesFilterList
    {
        [JsonProperty("type")]
        public AccountsType Type { get; set; }

        [JsonProperty("items")]
        public FilterListItems Items { get; set; }
    }
}
