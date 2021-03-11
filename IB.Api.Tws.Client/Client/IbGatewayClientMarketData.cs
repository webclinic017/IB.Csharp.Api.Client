using System;
using System.Collections.Generic;
using IB.Api.Tws.Client.Handler;

namespace IB.Api.Tws.Client.Client
{
    public class IbGatewayClientMarketData : IbGatewayClientBase
    {
        public event EventHandler<Price> OnPriceUpdateReceived;
        private void OnPriceUpdateReceivedHandler(Price price)
        {
            OnPriceUpdateReceived?.Invoke(this, price);
        }
        public Dictionary<int, Price> Prices = new Dictionary<int, Price> ();
        public void SubscribeToMarketData(int id, Contract contract)
        {
            ClientSocket.reqMktData(id, contract, string.Empty, false, false, null);
            Prices[id] = new Price
            {
                Id = id,
                Symbol = contract.Symbol
            };
        }
        public void UnsubscribeFromMarketData(int id)
        {
            ClientSocket.cancelMktData(id);
        }
        public override void tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            var priceItem = Prices[tickerId];
            switch (field)
            {
                case TickType.BID:
                    {
                        priceItem.Bid = price;
                        break;
                    }
                case TickType.ASK:
                    {
                        priceItem.Ask = price;
                        break;
                    }
            }
            Prices[tickerId] = priceItem;
            OnPriceUpdateReceivedHandler(priceItem);
        }
        public override void tickSize(int tickerId, int field, int size)
        {
            //Console.WriteLine("Tick Size. Ticker Id:" + tickerId + ", Field: " + field + ", Size: " + size);
        }
        public override void tickString(int tickerId, int tickType, string value)
        {
            //Console.WriteLine("Tick string. Ticker Id:" + tickerId + ", Type: " + tickType + ", Value: " + value);
        }
        public override void tickGeneric(int tickerId, int field, double value)
        {
            //Console.WriteLine("Tick Generic. Ticker Id:" + tickerId + ", Field: " + field + ", Value: " + value);
        }
        public override void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            //Console.WriteLine("TickEFP. "+tickerId+", Type: "+tickType+", BasisPoints: "+basisPoints+", FormattedBasisPoints: "+formattedBasisPoints+", ImpliedFuture: "+impliedFuture+", HoldDays: "+holdDays+", FutureLastTradeDate: "+futureLastTradeDate+", DividendImpact: "+dividendImpact+", DividendsToLastTradeDate: "+dividendsToLastTradeDate);
        }
        public override void tickSnapshotEnd(int tickerId)
        {
            //Console.WriteLine("TickSnapshotEnd: "+tickerId);
        }
        public void Disconnect()
        {
            ClientSocket.eDisconnect();
        }
    }
}
