using IB.Tws.Client.Types;

namespace IB.Tws.Client.Helper
{
    public class IbContractDefinition
    {        
        public static Contract Apple()
        {
            Contract contract = new Contract();
            contract.RequestId = 1000;
            contract.Symbol = "AAPL";
            contract.Currency = "USD";
            contract.SecType = "STK";
            contract.Exchange = "SMART";
            contract.PrimaryExch = "NASDAQ";
            return contract;
        }
        public static Contract NasdaqStock(int requestId, string symbol)
        {
            Contract contract = new Contract();
            contract.RequestId = requestId;
            contract.Symbol = symbol;
            contract.Currency = "USD";
            contract.SecType = "STK";
            contract.Exchange = "SMART";
            contract.PrimaryExch = "NASDAQ";
            return contract;
        }
        public static Contract EurGbpFx()
        {
            Contract contract = new Contract();
            contract.RequestId = 1001;
            contract.Symbol = "EUR";
            contract.SecType = "CASH";
            contract.Currency = "GBP";
            contract.Exchange = "IDEALPRO";
            return contract;
        }
        public static Contract Dax30()
        {
            Contract contract = new Contract();
            contract.RequestId = 1002;
            contract.Symbol = "DAX";
            contract.SecType = "IND";
            contract.Currency = "EUR";
            contract.Exchange = "DTB";
            return contract;
        }
        /// <summary>
        /// Attributes as per TWS definition screen
        /// </summary>
        /// <param name="symbol">Product on the TWS definition dialog</param>
        /// <param name="localSymbol">Symbol on the TWS definition dialog</param>
        /// <param name="exchange"></param>
        /// <returns></returns>
        public static Contract Future(int requestId, string symbol, string localSymbol, Exchange exchange)
        {
            Contract contract = new Contract();
            contract.RequestId = requestId;
            contract.Symbol = symbol;
            contract.SecType = "FUT";
            contract.Exchange = exchange.ToString();
            contract.LocalSymbol = localSymbol;
            return contract;         
        }
        public static Contract SampleFuture()
        {
            Contract contract = new Contract();
            contract.Symbol = "M6A";
            contract.SecType = "FUT";
            contract.Exchange = "GLOBEX";
            contract.LocalSymbol = "M6AM1";
            return contract;
        }
    }
}
