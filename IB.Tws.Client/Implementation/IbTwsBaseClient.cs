using System;
using System.Threading;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    {
        private readonly EReaderSignal _signal;
        private EClientSocket _clientSocket;
        private int NextOrderId;
        public string BboExchange { get; set; }

        public event EventHandler<string> OnLogReceived;

        public IbTwsClient(string address, int port, int clientId)
        {
            _signal = new EReaderMonitorSignal();
            _clientSocket = new EClientSocket(this, _signal);

            _clientSocket.eConnect(address, port, clientId);
            var reader = new EReader(_clientSocket, _signal);
            reader.Start();
            new Thread(() =>
            {
                while (_clientSocket.IsConnected())
                {
                    _signal.waitForSignal();
                    reader.processMsgs();
                }
            })
            { IsBackground = true }.Start();
        }
        private void LogEvent(string message)
        {
            message = $"{DateTime.Now.ToString()} | {message}";
            OnLogReceived?.Invoke(this, message);
            Console.WriteLine(message);
        }
        public void Disconnect()
        {
            _clientSocket.eDisconnect();
        }
        void EWrapper.error(Exception e)
        {
            LogEvent("Exception thrown: " + e);
            throw e;
        }
        void EWrapper.error(string str)
        {
            LogEvent("Error: " + str + "\n");
        }
        void EWrapper.error(int id, int errorCode, string errorMsg)
        {
            if (id == -1) LogEvent("Code: " + errorCode + ", Msg: " + errorMsg);
            else LogEvent("Error. Id: " + id + ", Code: " + errorCode + ", Msg: " + errorMsg);
        }
        void EWrapper.connectionClosed()
        {
            LogEvent("Connection closed.\n");
        }
        void EWrapper.currentTime(long time)
        {
            LogEvent("Current Time: " + time + "\n");
        }
        void EWrapper.nextValidId(int orderId)
        {
            LogEvent("Next Valid Id: " + orderId);
            NextOrderId = orderId;
        }        
    }
}
