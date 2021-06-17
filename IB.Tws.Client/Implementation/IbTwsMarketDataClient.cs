using System;
using System.Collections.Generic;
using IB.Tws.Client.Handler;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    {
        public event EventHandler<PriceHandler> OnPriceUpdateReceived;
        public Dictionary<int, PriceHandler> Prices = new Dictionary<int, PriceHandler>();
        public void SubscribeToMarketData(Contract contract)
        {
            _clientSocket.reqMktData(contract.RequestId, contract, string.Empty, false, false, null);
            Prices[contract.RequestId] = new PriceHandler
            {
                Id = contract.RequestId,
                Symbol = contract.Symbol
            };
        }
        public void UnsubscribeFromMarketData(int id)
        {
            _clientSocket.cancelMktData(id);
        }
        void EWrapper.tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            var priceItem = Prices[tickerId];
            switch (field)
            {
                case TickType.BID:
                    {
                        priceItem.At = DateTime.Now;
                        priceItem.Bid = price;
                        break;
                    }
                case TickType.ASK:
                    {
                        priceItem.At = DateTime.Now;
                        priceItem.Ask = price;
                        break;
                    }
            }
            Prices[tickerId] = priceItem;
            OnPriceUpdateReceived?.Invoke(this, priceItem);
        }
    }
}
