namespace IB.Tws.Client.Handler
{
    public class PositionHandler
    {
        public Contract Contract { get; set; }
        public double Value { get; set; }
        public double MarketPrice { get; set; }
        public double UnrealizedPNL { get; set; }

        public PositionHandler(Contract contract, double positionValue, double marketPrice, double unrealizedPNL)
        {
            Contract = contract;
            Value = positionValue;
            MarketPrice = marketPrice;
            UnrealizedPNL = unrealizedPNL;
        }
    }
}
