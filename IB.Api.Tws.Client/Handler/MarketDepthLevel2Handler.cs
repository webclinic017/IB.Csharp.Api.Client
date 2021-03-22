using System;

namespace IB.Api.Tws.Client.Handler
{
    public class MarketDepthLevel2Handler
    {
        public int TickerId { get; set; }
        public int Position { get; set; }
        public string MarketMaker { get; set; }
        public int Operation { get; set; }
        public int Side { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public bool IsSmartDepth { get; set; }
        public DateTime At { get; set; }
    }
}
