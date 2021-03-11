using System;
using System.Collections.Generic;
using IB.Api.Tws.Client.Handler;

namespace IB.Api.Tws.Client.Client
{
    public class IbGatewayClientAccounts : IbGatewayClientBase
    {
        private Dictionary<string, string> _accountDictionary; 
        private string _accountId;
        
        public IbGatewayClientAccounts()
        {            
            _accountDictionary = new Dictionary<string, string>();
        }
        public void SetAccountId(string accountId)
        {
            _accountId = accountId;
        }
        public event EventHandler<Account> OnAccountReceived;
        private void OnAccountReceivedHandler(Dictionary<string,string> accountDictionary)
        {
            OnAccountReceived?.Invoke(this, new Account(accountDictionary));
        }
        public void SubscribeToAccountUpdates()
        {
            ClientSocket.reqAccountUpdates(true, _accountId); 
        }
        public void UnsubscribeFromAccountUpdates()
        {
            ClientSocket.reqAccountUpdates(false, _accountId); 
        }
        public override void updateAccountValue(string key, string value, string currency, string accountName)
        {
            _accountDictionary[key] = value;
        }
        public override void updateAccountTime(string timestamp)
        {
            _accountDictionary["UpdateAccountTime"] = timestamp;
        }
        public override void accountDownloadEnd(string account)
        {
            OnAccountReceivedHandler(_accountDictionary);
        }
        public void Disconnect()
        {
            ClientSocket.eDisconnect();
        }
    }
}
