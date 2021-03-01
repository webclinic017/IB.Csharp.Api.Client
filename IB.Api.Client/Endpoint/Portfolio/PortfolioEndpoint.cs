using IB.Api.Client.Endpoint.Portfolio.Response;

namespace IB.Api.Client.Endpoint.Portfolio
{
    public class PortfolioEndpoint : BaseEndpoint
    {
        public PositionsResponse Positions(string accountId)
        {
            return GetApiResponse<PositionsResponse>($"/portfolio/{accountId}/positions/0");
        }
    }
}
