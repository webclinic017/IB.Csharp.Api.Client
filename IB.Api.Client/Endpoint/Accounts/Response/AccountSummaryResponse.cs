using Newtonsoft.Json.Linq;

namespace IB.Api.Client.Endpoint.Accounts.Response
{
    public class AccountSummaryResponse
    {
        public string AccountCode { get; }
        public bool IsReady { get; }
        public string AccountType { get; }
        public double AvailableFunds { get; }
        public double BuyingPower { get; }
        public double ExcessLiquidity { get; }
        public AccountSummaryResponse(JObject data)
        {
            AccountCode = data["accountcode"]["value"].Value<string>();
            IsReady = data["accountready"]["value"].Value<bool>();
            AccountType = data["accounttype"]["value"].Value<string>();
            AvailableFunds = data["availablefunds"]["amount"].Value<double>();
            BuyingPower = data["buyingpower"]["amount"].Value<double>();
            ExcessLiquidity = data["excessliquidity"]["amount"].Value<double>();
        }
    }
}
