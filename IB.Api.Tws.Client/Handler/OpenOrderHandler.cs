namespace IB.Api.Tws.Client.Handler
{
    public class OpenOrderHandler
    {
        public int OrderId { get; set; }
        public Contract Contract { get; set; }
        public Order Order { get; set; }
        public OrderState OrderState { get; set; }
    }
}
