using System;
using IB.Api.Tws.Client.Handler;

namespace IB.Api.Tws.Client.Client
{
    public class IbGatewayClientPositions : IbGatewayClientBase
    {
        public event EventHandler<Position> OnPortfolioUpdateReceived;
        private void OnPortfolioUpdateReceivedHandler(Contract contract, double position, double marketPrice, double unrealizedPNL)
        {
            OnPortfolioUpdateReceived?.Invoke(this, new Position(contract, position, marketPrice, unrealizedPNL));
        }
        public void SubscribeToPositionUpdates()
        {
            ClientSocket.reqPositions();
        }
        public void UnsubscribeFromPositionUpdates()
        {
            ClientSocket.cancelPositions();
        }        
        public override void position(string account, Contract contract, double pos, double avgCost)
        {
            Console.WriteLine("Position. "+account+" - Symbol: "+contract.Symbol+", SecType: "+contract.SecType+", Currency: "+contract.Currency+", Position: "+pos+", Avg cost: "+avgCost);
        }
        public override void positionEnd()
        {
            Console.WriteLine("PositionEnd \n");
        }
        public override void updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
        {
            OnPortfolioUpdateReceivedHandler(contract, position, marketPrice, unrealizedPNL);
        }
        public void Disconnect()
        {
            ClientSocket.eDisconnect();
        }
    }
}
