namespace IB.Api.Tws.Client.Helper
{
    public class IbContractDefinition
    {
        public static Contract EurGbpFx()
        {
            Contract contract = new Contract();
            contract.Symbol = "EUR";
            contract.SecType = "CASH";
            contract.Currency = "GBP";
            contract.Exchange = "IDEALPRO";
            return contract;
        }
        public static Contract Dax30()
        {
            Contract contract = new Contract();
            contract.Symbol = "DAX";
            contract.SecType = "IND";
            contract.Currency = "EUR";
            contract.Exchange = "DTB";
            return contract;
        }
        public static Contract Apple()
        {
            Contract contract = new Contract();
            contract.Symbol = "AAPL";
            contract.Currency = "USD";
            contract.SecType = "STK";
            contract.Exchange = "SMART";
            contract.PrimaryExch = "NASDAQ";
            return contract;
        }
    }
}
