using System;
using IB.Tws.Client.Handler;
using IB.Tws.Client.Helper;
using IB.Tws.Client.Types;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    {
        public event EventHandler<OpenOrderHandler> OnOpenOrderUpdateReceived;
        public event EventHandler<OrderStatusHandler> OnOrderStatusReceived;
        public void RequestCompletedOrders()
        {
            _clientSocket.reqCompletedOrders(true);
        }        
        public void OpenMarketOrder(OrderSide side, Contract contract, double quantity)
        {
            _clientSocket.placeOrder(NextOrderId++, contract, OrderHelper.MarketOrder(side, quantity));
        }
        public void PreviewMarketOrder(OrderSide side, Contract contract, double quantity)
        {
            _clientSocket.placeOrder(NextOrderId++, contract, OrderHelper.WhatIfMarketOrder(side, quantity));
        }
        void EWrapper.orderStatus(int orderId, string status, double filled, double remaining, double avgFillPrice, int permId, int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            var orderStatusHandler = new OrderStatusHandler
            {
                OrderId = orderId,
                Status = status,
                Filled = filled,
                Remaining = remaining,
                AvgFillPrice = avgFillPrice,
                PermId = permId,
                ParentId = parentId,
                LastFillPrice = lastFillPrice,
                ClientId = clientId,
                WhyHeld = whyHeld,
                MktCapPrice = mktCapPrice
            };
            OnOrderStatusReceived?.Invoke(this, orderStatusHandler);
        }
        void EWrapper.openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            var openOrder = new OpenOrderHandler
            {
                OrderId = orderId,
                Contract = contract,
                Order = order,
                OrderState = orderState
            };
            OnOpenOrderUpdateReceived?.Invoke(this, openOrder);
        }
        void EWrapper.openOrderEnd() { }
        void EWrapper.completedOrder(Contract contract, Order order, OrderState orderState)
        {
            var orderStatusHandler = new OrderStatusHandler
            {
                Status = orderState.Status,
                PermId = order.PermId
            };
            OnOrderStatusReceived?.Invoke(this, orderStatusHandler);
        }
        void EWrapper.completedOrdersEnd() { }
    }
}
