using System.Collections.Generic;
using System.Linq;

namespace IB.Api.Client.Run
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseUri = "https://localhost:5000/v1/portal";

            var ibRestApiClient = new RestApiClient(baseUri, getUserAgent());
            var portfolioAccountsResponse = ibRestApiClient.PortfolioAccounts();
            var account = portfolioAccountsResponse.FirstOrDefault(x => x.Type == "DEMO");
            //var transactions = ibRestApiClient.PortfolioAnalystTransactionHistory(new List<string> { account.AccountId }, 7);
            var contracts = ibRestApiClient.ContractSearch("GBP.USD", true);
        }

        private static string getUserAgent()
        {
            //change user agent to match the browser you have used to authenticate
            return "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:85.0) Gecko/20100101 Firefox/85.0";
        }
    }
}