using IB.Api.Client.Endpoint.Accounts.Response;
using Newtonsoft.Json.Linq;

namespace IB.Api.Client.Endpoint.Accounts
{
    public class AccountsEndpoint : BaseEndpoint
    {
        public AccountsResponse Accounts()
        {
            return GetApiResponse<AccountsResponse>("/portfolio/accounts");
        }
        public SubAccountsResponse SubAccounts()
        {
            return GetApiResponse<SubAccountsResponse>("/portfolio/subaccounts");
        }
        public AccountSummaryResponse AccountSummary(string accountId)
        {
            JObject data = GetApiResponse<JObject>($"/portfolio/{accountId}/summary");
            return new AccountSummaryResponse(data);
        }
        public AccountLedgerResponse AccountLedger(string accountId)
        {
            return GetApiResponse<AccountLedgerResponse>($"/portfolio/{accountId}/ledger");
        }
    }
}
