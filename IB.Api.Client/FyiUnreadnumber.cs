namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class FyiUnreadnumber
    {
        [JsonProperty("get")]
        public FyiUnreadnumberGet Get { get; set; }
    }
}
