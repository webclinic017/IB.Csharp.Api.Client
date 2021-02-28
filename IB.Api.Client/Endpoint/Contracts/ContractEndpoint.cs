using IB.Api.Client.Endpoint.Contracts.Request;
using IB.Api.Client.Endpoint.Contracts.Response;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Contracts
{
    public class ContractEndpoint : BaseEndpoint
    {
        public ContractSearchResponse ContractSearch(string searchText, bool isName)
        {
            var request = new ContractSearchRequest
            {
                Symbol = searchText,
                IsName = isName
            };
            var payload = JsonConvert.SerializeObject(request);
            return PostApiResponse<ContractSearchResponse>("/iserver/secdef/search", payload);
        }
    }
}
