namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class GroupProperties
    {
        [JsonProperty("long")]
        public PurpleLong Long { get; set; }

        [JsonProperty("short")]
        public PurpleShort Short { get; set; }
    }
}
