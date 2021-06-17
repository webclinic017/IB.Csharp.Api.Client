using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using IB.Tws.Client.Handler;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    {
        private List<AccountUpdateHandler> _accountUpdates;
        public event EventHandler<List<AccountUpdateHandler>> OnUpdateAccounts;

        //single account        
        public void SubscribeToAccountUpdates(string account)
        {
            _accountUpdates = new List<AccountUpdateHandler>();
            _clientSocket.reqAccountUpdates(true, account);
            _accountUpdates.Add(new AccountUpdateHandler(1, account));
        }
        public void UnsubscribefromAccountUpdates(string account)
        {
            _clientSocket.reqAccountUpdates(false, account);
        }
        void EWrapper.updateAccountValue(string key, string value, string currency, string accountName)
        {
            _accountUpdates.ForEach(accountUpdateHandler =>
            {
                if (accountUpdateHandler.AccountId == accountName)
                    accountUpdateHandler.AccountValues[key] = value;
            });
        }
        void EWrapper.accountDownloadEnd(string account)
        {
            OnUpdateAccounts?.Invoke(this, _accountUpdates);
            LogEvent($"Subscribed to account: {account} updates");
        }
        void EWrapper.accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            throw new NotImplementedException();
        }
        void EWrapper.accountSummaryEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        //Multiple accounts
        public void SubscribeToAllAccountUpdates(List<string> accounts)
        {
            _accountUpdates = new List<AccountUpdateHandler>();

            foreach (var account in accounts)
            {
                var requestId = int.Parse(Regex.Match(account, @"\d+").Value);
                _clientSocket.reqAccountUpdatesMulti(requestId, account, "", false);
                _accountUpdates.Add(new AccountUpdateHandler(requestId, account));
            }
        }
        public void UnSubscribeToAllAccountUpdates(List<string> accounts)
        {
            foreach (var account in accounts)
            {
                var requestId = int.Parse(Regex.Match(account, @"\d+").Value);
                _clientSocket.cancelAccountUpdatesMulti(requestId);
                LogEvent($"Unsubscribed from account: {requestId} updates");
            }
        }
        void EWrapper.accountUpdateMulti(int requestId, string account, string modelCode, string key, string value, string currency)
        {
            _accountUpdates.ForEach(accountUpdateHandler =>
            {
                if (accountUpdateHandler.AccountId == account)
                    accountUpdateHandler.AccountValues[key] = value;
            });
        }     
        void EWrapper.accountUpdateMultiEnd(int requestId)
        {
            OnUpdateAccounts?.Invoke(this, _accountUpdates);
            LogEvent($"Subscribed to multiple accounts: {requestId} updates");
        }

        public event EventHandler<PositionHandler> OnPortfolioUpdateReceived;

        /// <summary>
        /// This method is triggered when account is subscribed to accountUpdates
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="position"></param>
        /// <param name="marketPrice"></param>
        /// <param name="marketValue"></param>
        /// <param name="averageCost"></param>
        /// <param name="unrealizedPNL"></param>
        /// <param name="realizedPNL"></param>
        /// <param name="accountName"></param>
        void EWrapper.updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
        {
            OnPortfolioUpdateReceived?.Invoke(this, new PositionHandler(contract, position, marketPrice, unrealizedPNL));
        }
        void EWrapper.position(string account, Contract contract, double pos, double avgCost)
        {
            OnPortfolioUpdateReceived?.Invoke(this, new PositionHandler(contract, pos, 0, 0));
        }
        void EWrapper.positionEnd()
        {
            LogEvent($"Positions updated");
        }      
    }
}
