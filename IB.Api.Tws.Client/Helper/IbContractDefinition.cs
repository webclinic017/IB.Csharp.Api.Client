using IB.Api.Tws.Client.Types;

namespace IB.Api.Tws.Client.Helper
{
    public class IbContractDefinition
    {        
        public static Contract Apple()
        {
            Contract contract = new Contract();
            contract.Id = 1000;
            contract.Symbol = "AAPL";
            contract.Currency = "USD";
            contract.SecType = "STK";
            contract.Exchange = "SMART";
            contract.PrimaryExch = "NASDAQ";
            return contract;
        }
        public static Contract NasdaqStock(int id, string symbol)
        {
            Contract contract = new Contract();
            contract.Id = id;
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
            contract.Id = 1001;
            contract.Symbol = "EUR";
            contract.SecType = "CASH";
            contract.Currency = "GBP";
            contract.Exchange = "IDEALPRO";
            return contract;
        }
        public static Contract Dax30()
        {
            Contract contract = new Contract();
            contract.Id = 1002;
            contract.Symbol = "DAX";
            contract.SecType = "IND";
            contract.Currency = "EUR";
            contract.Exchange = "DTB";
            return contract;
        }
        /// <summary>
        /// Attributes as per TWS definition screen
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <param name="symbol"></param>
        /// <param name="exchange"></param>
        /// <returns></returns>
        public static Contract Future(int id, string product, string symbol, Exchange exchange)
        {
            Contract contract = new Contract();
            contract.Id = id;
            contract.Symbol = product;
            contract.SecType = "FUT";
            contract.Exchange = exchange.ToString();
            contract.LocalSymbol = symbol;
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
