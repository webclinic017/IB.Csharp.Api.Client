namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Logout
    {
        [JsonProperty("post")]
        public IserverMarketdataUnsubscribeallGet Post { get; set; }
    }
}
