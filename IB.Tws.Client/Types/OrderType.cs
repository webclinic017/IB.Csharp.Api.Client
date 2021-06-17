namespace IB.Tws.Client.Types
{
    public class OrderType
    {
        public static string Market = "MKT";
        public static string Limit = "LMT";
        public static string MarketIfTouched = "MIT";
        public static string MarketToLimit = "MTL";
        public static string MarketOnClose = "MOC";
        public static string MidPrice = "MIDPRICE";
        public static string PeggedToMarket = "PEG MKT";
        public static string PeggedToStock = "PEG STK";
        public static string RelativePeggedToPrimary = "REL";
    }
}