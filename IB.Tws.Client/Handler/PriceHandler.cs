using System;

namespace IB.Tws.Client.Handler
{
    public class PriceHandler
    {
        public string Description { get; set; }
        public DateTime At { get; set; }
        public int Id { get; set; }
        public string Symbol { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
    }
}
