using System;
using System.Collections.Generic;
using IB.Tws.Client.Types;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    {
        public event EventHandler<List<ContractDetails>> OnContractDetailsReceived;
        private List<ContractDetails> _contractDetailsList;
        public void RequestContractDetails(int id, string symbol, SecurityType securityType)
        {
            _contractDetailsList = new List<ContractDetails>();
            _clientSocket.reqContractDetails(id,
                new Contract
                {
                    Symbol = symbol,
                    SecType = securityType.ToString()
                });
        }
        void EWrapper.contractDetails(int reqId, ContractDetails contractDetails)
        {
            _contractDetailsList.Add(contractDetails);
        }
        void EWrapper.contractDetailsEnd(int reqId)
        {
            OnContractDetailsReceived?.Invoke(this, _contractDetailsList);
        }
    }
}
