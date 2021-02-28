namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Properties56
    {
        [JsonProperty("LOGIN_TYPE")]
        public AlertMessage LoginType { get; set; }

        [JsonProperty("USER_NAME")]
        public AlertMessage UserName { get; set; }

        [JsonProperty("USER_ID")]
        public AlertMessage UserId { get; set; }

        [JsonProperty("expire")]
        public AlertMessage Expire { get; set; }

        [JsonProperty("RESULT")]
        public AlertMessage Result { get; set; }

        [JsonProperty("AUTH_TIME")]
        public AlertMessage AuthTime { get; set; }
    }
}
