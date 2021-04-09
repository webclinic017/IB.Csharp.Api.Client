using System;
using System.Collections.Generic;

namespace IB.Api.Tws.Client.Handler
{
    public class AccountUpdateHandler
    {
        public int AccountRequestId { get; set; }
        public string AccountId { get; set; }        
        public Dictionary<string, string> AccountValues { get; set; }

        public string AccountType
        {
            get
            {
                return AccountValues["AccountType"];
            }
        }
        public string AccountAlias
        {
            get
            {
                return AccountValues["AccountOrGroup"];
            }
        }
        public double AvailableFunds
        {
            get
            {
                return Math.Round(double.Parse(AccountValues["AvailableFunds"]), 2);
            }
        }
        public double BuyingPower
        {
            get
            {
                return Math.Round(double.Parse(AccountValues["BuyingPower"]), 2);
            }
        }
        public double Cash
        {
            get
            {
                return Math.Round(double.Parse(AccountValues["TotalCashValue"]), 2);
            }
        }
        public double ExcessLiquidity
        {
            get
            {
                return Math.Round(double.Parse(AccountValues["ExcessLiquidity"]), 2);
            }
        }

        public AccountUpdateHandler(int accountRequestId, string accountId)
        {
            AccountRequestId = accountRequestId;
            AccountId = accountId;
            AccountValues = new Dictionary<string, string>();
        }
    }
}
