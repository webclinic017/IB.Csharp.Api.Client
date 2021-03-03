using System.Collections.Generic;
using IB.Api.Client.Endpoint.PortfolioAnalyst.Request;
using IB.Api.Client.Endpoint.PortfolioAnalyst.Response;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.PortfolioAnalyst
{
    public class PortfolioAnalystEndpoint : BaseEndpoint
    {
        public TransactionHistoryResponse PortfolioAnalystTransactionHistory(List<string> accountIds, List<long> contractIds, int days)
        {
            var request = new TransactionHistoryRequest
            {
                AccountIds = accountIds,
                Days = days,
                Currency = "GBP",
                ConIds = contractIds
            };
            var payload = JsonConvert.SerializeObject(request);
            return PostApiResponse<TransactionHistoryResponse>("/pa/transactions", payload);
        }
    }
}
