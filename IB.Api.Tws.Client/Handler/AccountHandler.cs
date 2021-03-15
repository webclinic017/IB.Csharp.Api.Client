using System;
using System.Collections.Generic;

namespace IB.Api.Tws.Client.Handler
{
    public class AccountHandler
    {
        public string AccountCode { get; set; }
        public bool IsReady { get; set; }
        public string AccountType { get; set; }
        public double AvailableFunds { get; set; }
        public double BuyingPower { get; set; }
        public double ExcessLiquidity { get; set; }
        public double Cash { get; set; }

        public AccountHandler(Dictionary<string, string> accountDictionary)
        {
            AccountCode = accountDictionary["AccountCode"];
            AccountType = accountDictionary["AccountType"];
            AvailableFunds = Math.Round(double.Parse(accountDictionary["AvailableFunds"]), 2);
            BuyingPower = Math.Round(double.Parse(accountDictionary["BuyingPower"]), 2);
            Cash = Math.Round(double.Parse(accountDictionary["TotalCashValue"]), 2);
            ExcessLiquidity = Math.Round(double.Parse(accountDictionary["ExcessLiquidity"]), 2);
            IsReady = true;
        }
    }
}
