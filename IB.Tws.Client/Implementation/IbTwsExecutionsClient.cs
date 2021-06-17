using System;
using System.Collections.Generic;
using IB.Tws.Client.Handler;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    { 
        public event EventHandler<List<ExecutionHandler>> OnExecutionUpdateReceived;
        private List<ExecutionHandler> executions;
        public void RequestExecutions()
        {
            executions = new List<ExecutionHandler>();
            _clientSocket.reqExecutions(10001, new ExecutionFilter());
        }
        void EWrapper.execDetails(int reqId, Contract contract, Execution execution)
        {
            executions.Add(new ExecutionHandler
            {
                Contract = contract,
                Execution = execution
            });
        }
        void EWrapper.commissionReport(CommissionReport commissionReport)
        {
            executions.ForEach(execution =>
            {
                if (commissionReport.ExecId == execution.Execution.ExecId)
                {
                    execution.CommissionReport = commissionReport;
                }
            });
        }
        void EWrapper.execDetailsEnd(int reqId)
        {
            OnExecutionUpdateReceived?.Invoke(this, executions);
        }                
    }
}
