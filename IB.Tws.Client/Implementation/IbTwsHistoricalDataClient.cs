using System;
using IB.Tws.Client.Handler;
using IB.Tws.Client.Types;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    {
        public event EventHandler<HistoricalDataHandler> OnHistoricalDataReceived;
        public event EventHandler<string> OnHistoricalEnd;
        public void RequestHistoricalData(DateTime to, Contract contract, int duration, DurationUnit durationUnit, int barSize, BarSizeUnit barSizeUnit, HistoricalDataType historicalDataType)
        {
            string endDate = to.ToString("yyyyMMdd HH:mm:ss");
            _clientSocket.reqHistoricalData(contract.RequestId, contract, endDate, $"{duration} {durationUnit}", $"{barSize} {barSizeUnit}", historicalDataType.ToString(), 0, 1, false, null);
        }
        void EWrapper.historicalData(int reqId, Bar bar)
        {
            var historicalDataHandler = new HistoricalDataHandler
            {
                RequestId = reqId,
                BarData = bar
            };
            OnHistoricalDataReceived?.Invoke(this, historicalDataHandler);
        }
        void EWrapper.historicalDataEnd(int reqId, string start, string end)
        {
            OnHistoricalEnd?.Invoke(this, "HistoricalDataEnd - " + reqId + " from " + start + " to " + end);
        }
    }
}
