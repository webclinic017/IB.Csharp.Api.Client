namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties10
    {
        [JsonProperty("id")]
        public AccountAlias Id { get; set; }

        [JsonProperty("groupId")]
        public AccountAlias GroupId { get; set; }

        [JsonProperty("name")]
        public AccountAlias Name { get; set; }

        [JsonProperty("date")]
        public FluffyDate Date { get; set; }
    }
}
