using IB.Api.Client.Model;
using Newtonsoft.Json;

namespace IB.Api.Client.Response
{
    public class SessionValidateResponse
    {
        [JsonProperty("PAPER_USER_NAME")]
        public string PaperUserName { get; set; }

        [JsonProperty("LOGIN_TYPE")]
        public long LoginType { get; set; }

        [JsonProperty("IS_PENDING_APPLICANT")]
        public bool IsPendingApplicant { get; set; }

        [JsonProperty("SF_ENABLED")]
        public bool SfEnabled { get; set; }

        [JsonProperty("AUTH_TIME")]
        public long AuthTime { get; set; }

        [JsonProperty("CREDENTIAL")]
        public string Credential { get; set; }

        [JsonProperty("SF_CONFIG")]
        public string SfConfig { get; set; }

        [JsonProperty("USER_NAME")]
        public string UserName { get; set; }

        [JsonProperty("CREDENTIAL_TYPE")]
        public long CredentialType { get; set; }

        [JsonProperty("RESULT")]
        public bool Result { get; set; }

        [JsonProperty("IS_FREE_TRIAL")]
        public bool IsFreeTrial { get; set; }

        [JsonProperty("IP")]
        public string Ip { get; set; }

        [JsonProperty("USER_ID")]
        public long UserId { get; set; }

        [JsonProperty("EXPIRES")]
        public long Expires { get; set; }

        [JsonProperty("TOKEN")]
        public string Token { get; set; }

        [JsonProperty("took")]
        public long Took { get; set; }

        [JsonProperty("features")]
        public Features Features { get; set; }

        [JsonProperty("isGw")]
        public bool IsGw { get; set; }
    }
}
