namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class MasterProperties
    {
        [JsonProperty("title")]
        public AccountAlias Title { get; set; }

        [JsonProperty("officialTitle")]
        public AccountAlias OfficialTitle { get; set; }
    }
}
