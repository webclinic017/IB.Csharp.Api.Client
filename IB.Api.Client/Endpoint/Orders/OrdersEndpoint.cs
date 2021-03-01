using IB.Api.Client.Endpoint.Orders.Request;
using IB.Api.Client.Endpoint.Orders.Response;
using IB.Api.Client.Enum;
using Newtonsoft.Json;

namespace IB.Api.Client.Endpoint.Orders
{
    public class OrdersEndpoint : BaseEndpoint
    {
        public OrdersResponse Orders()
        {
            return GetApiResponse<OrdersResponse>($"/iserver/account/orders");
        }
        public PlaceOrderResponse PlaceMarketOrder(string accountId, int contractId, double quantity)
        {
            var request = new OrderRequest
            {
                AccountId = accountId,
                ContractId = contractId,
                OrderType = OrderType.MKT,
                ListingExchange = Exchange.SMART,
                OutsideRegularHours = false,
                Side = Side.BUY,
                Quantity = quantity,
                Expiry = TimeInForce.GTC,
                AllocationMethod = AllocationMethod.AvailableEquity
            };
            var payload = JsonConvert.SerializeObject(request);
            return PostApiResponse<PlaceOrderResponse>($"/iserver/account/{accountId}/order", payload, true);
        }
        public OrderPreviewResponse MarketOrderPreview(string accountId, int contractId, double quantity)
        {
            var request = new OrderRequest
            {
                AccountId = accountId,
                ContractId = contractId,
                OrderType = OrderType.MKT,
                ListingExchange = Exchange.SMART,
                OutsideRegularHours = false,
                Side = Side.BUY,
                Quantity = quantity,
                Expiry = TimeInForce.GTC,
                AllocationMethod = AllocationMethod.AvailableEquity
            };
            var payload = JsonConvert.SerializeObject(request);
            return PostApiResponse<OrderPreviewResponse>($"/iserver/account/{accountId}/order/whatif", payload, true);
        }
    }
}
