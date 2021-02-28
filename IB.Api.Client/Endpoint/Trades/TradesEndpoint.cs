using IB.Api.Client.Endpoint.Trades.Response;

namespace IB.Api.Client.Endpoint.Trades
{
    public class TradesEndpoint : BaseEndpoint
    {
        public TradesResponse Trades()
        {
            return GetApiResponse<TradesResponse>("/iserver/account/trades");
        }
    }
}
