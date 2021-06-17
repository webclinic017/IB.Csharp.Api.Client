using System;
using IB.Tws.Client.Handler;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    {
        public event EventHandler<MarketDepthLevel2Handler> OnMarketDepthLevel2Received;

        public void RequestMarketDepth(int id, Contract contract)
        {
            _clientSocket.reqMarketDepth(id, contract, 5, true, null);
        }
        void EWrapper.updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size, bool isSmartDepth)
        {
            var data = new MarketDepthLevel2Handler
            {
                At = DateTime.Now,
                TickerId = tickerId,
                Position = position,
                MarketMaker = marketMaker,
                Operation = operation,
                Side = side,
                Price = price,
                Size = size,
                IsSmartDepth = isSmartDepth
            };
            OnMarketDepthLevel2Received?.Invoke(this, data);
        }
    }
}
