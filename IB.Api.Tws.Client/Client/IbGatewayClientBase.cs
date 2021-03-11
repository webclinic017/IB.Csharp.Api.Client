using System;
using System.Collections.Generic;
using System.Threading;

namespace IB.Api.Tws.Client.Client
{
    public class IbGatewayClientBase : EWrapper
    {
        public EReaderSignal Signal;
        
        public EClientSocket ClientSocket;
        public string BboExchange { get; set; }

        public IbGatewayClientBase() { }

        public IbGatewayClientBase(string address, int port, int clientId)
        {
            Signal = new EReaderMonitorSignal();
            ClientSocket = new EClientSocket(this, Signal);            

            ClientSocket.eConnect(address, port, clientId);
            var reader = new EReader(ClientSocket, Signal);
            reader.Start();
            new Thread(() =>
            {
                while (ClientSocket.IsConnected())
                {
                    Signal.waitForSignal();
                    reader.processMsgs();
                }
            })
            { IsBackground = true }.Start();
        }   
        public virtual void accountDownloadEnd(string account)
        {
            throw new NotImplementedException();
        }
        public virtual void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            throw new NotImplementedException();
        }

        public virtual void accountSummaryEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        public virtual void accountUpdateMulti(int requestId, string account, string modelCode, string key, string value, string currency)
        {
            throw new NotImplementedException();
        }

        public virtual void accountUpdateMultiEnd(int requestId)
        {
            throw new NotImplementedException();
        }

        public virtual void bondContractDetails(int reqId, ContractDetails contract)
        {
            throw new NotImplementedException();
        }

        public virtual void commissionReport(CommissionReport commissionReport)
        {
            throw new NotImplementedException();
        }

        public virtual void completedOrder(Contract contract, Order order, OrderState orderState)
        {
            throw new NotImplementedException();
        }

        public virtual void completedOrdersEnd()
        {
            throw new NotImplementedException();
        }

        public virtual void connectAck()
        {
            throw new NotImplementedException();
        }

        public virtual void connectionClosed()
        {
            throw new NotImplementedException();
        }

        public virtual void contractDetails(int reqId, ContractDetails contractDetails)
        {
            throw new NotImplementedException();
        }

        public virtual void contractDetailsEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        public virtual void currentTime(long time)
        {
            throw new NotImplementedException();
        }

        public virtual void deltaNeutralValidation(int reqId, DeltaNeutralContract deltaNeutralContract)
        {
            throw new NotImplementedException();
        }

        public virtual void displayGroupList(int reqId, string groups)
        {
            throw new NotImplementedException();
        }

        public virtual void displayGroupUpdated(int reqId, string contractInfo)
        {
            throw new NotImplementedException();
        }

        public virtual void error(Exception e)
        {
            throw new NotImplementedException();
        }

        public virtual void error(string str)
        {
            throw new NotImplementedException();
        }

        public virtual void error(int id, int errorCode, string errorMsg)
        {
            throw new NotImplementedException();
        }

        public virtual void execDetails(int reqId, Contract contract, Execution execution)
        {
            throw new NotImplementedException();
        }

        public virtual void execDetailsEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        public virtual void familyCodes(FamilyCode[] familyCodes)
        {
            throw new NotImplementedException();
        }

        public virtual void fundamentalData(int reqId, string data)
        {
            throw new NotImplementedException();
        }

        public virtual void headTimestamp(int reqId, string headTimestamp)
        {
            throw new NotImplementedException();
        }

        public virtual void histogramData(int reqId, HistogramEntry[] data)
        {
            throw new NotImplementedException();
        }

        public virtual void historicalData(int reqId, Bar bar)
        {
            throw new NotImplementedException();
        }

        public virtual void historicalDataEnd(int reqId, string start, string end)
        {
            throw new NotImplementedException();
        }

        public virtual void historicalDataUpdate(int reqId, Bar bar)
        {
            throw new NotImplementedException();
        }

        public virtual void historicalNews(int requestId, string time, string providerCode, string articleId, string headline)
        {
            throw new NotImplementedException();
        }

        public virtual void historicalNewsEnd(int requestId, bool hasMore)
        {
            throw new NotImplementedException();
        }

        public virtual void historicalTicks(int reqId, HistoricalTick[] ticks, bool done)
        {
            throw new NotImplementedException();
        }

        public virtual void historicalTicksBidAsk(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            throw new NotImplementedException();
        }

        public virtual void historicalTicksLast(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            throw new NotImplementedException();
        }

        public virtual void managedAccounts(string accountsList)
        {
            throw new NotImplementedException();
        }

        public virtual void marketDataType(int reqId, int marketDataType)
        {
            throw new NotImplementedException();
        }

        public virtual void marketRule(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            throw new NotImplementedException();
        }

        public virtual void mktDepthExchanges(DepthMktDataDescription[] depthMktDataDescriptions)
        {
            throw new NotImplementedException();
        }

        public virtual void newsArticle(int requestId, int articleType, string articleText)
        {
            throw new NotImplementedException();
        }

        public virtual void newsProviders(NewsProvider[] newsProviders)
        {
            throw new NotImplementedException();
        }

        public virtual void nextValidId(int orderId)
        {
            throw new NotImplementedException();
        }

        public virtual void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            throw new NotImplementedException();
        }

        public virtual void openOrderEnd()
        {
            throw new NotImplementedException();
        }

        public virtual void orderBound(long orderId, int apiClientId, int apiOrderId)
        {
            throw new NotImplementedException();
        }

        public virtual void orderStatus(int orderId, string status, double filled, double remaining, double avgFillPrice, int permId, int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            throw new NotImplementedException();
        }

        public virtual void pnl(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            throw new NotImplementedException();
        }

        public virtual void pnlSingle(int reqId, int pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            throw new NotImplementedException();
        }

        public virtual void position(string account, Contract contract, double pos, double avgCost)
        {
            throw new NotImplementedException();
        }

        public virtual void positionEnd()
        {
            throw new NotImplementedException();
        }

        public virtual void positionMulti(int requestId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            throw new NotImplementedException();
        }

        public virtual void positionMultiEnd(int requestId)
        {
            throw new NotImplementedException();
        }

        public virtual void realtimeBar(int reqId, long date, double open, double high, double low, double close, long volume, double WAP, int count)
        {
            throw new NotImplementedException();
        }

        public virtual void receiveFA(int faDataType, string faXmlData)
        {
            throw new NotImplementedException();
        }

        public virtual void rerouteMktDataReq(int reqId, int conId, string exchange)
        {
            throw new NotImplementedException();
        }

        public virtual void rerouteMktDepthReq(int reqId, int conId, string exchange)
        {
            throw new NotImplementedException();
        }

        public virtual void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            throw new NotImplementedException();
        }

        public virtual void scannerDataEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        public virtual void scannerParameters(string xml)
        {
            throw new NotImplementedException();
        }

        public virtual void securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            throw new NotImplementedException();
        }

        public virtual void securityDefinitionOptionParameterEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        public virtual void smartComponents(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
        {
            throw new NotImplementedException();
        }

        public virtual void softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
            throw new NotImplementedException();
        }

        public virtual void symbolSamples(int reqId, ContractDescription[] contractDescriptions)
        {
            throw new NotImplementedException();
        }

        public virtual void tickByTickAllLast(int reqId, int tickType, long time, double price, int size, TickAttribLast tickAttriblast, string exchange, string specialConditions)
        {
            throw new NotImplementedException();
        }

        public virtual void tickByTickBidAsk(int reqId, long time, double bidPrice, double askPrice, int bidSize, int askSize, TickAttribBidAsk tickAttribBidAsk)
        {
            throw new NotImplementedException();
        }

        public virtual void tickByTickMidPoint(int reqId, long time, double midPoint)
        {
            throw new NotImplementedException();
        }

        public virtual void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            throw new NotImplementedException();
        }

        public virtual void tickGeneric(int tickerId, int field, double value)
        {
            throw new NotImplementedException();
        }

        public virtual void tickNews(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            throw new NotImplementedException();
        }

        public virtual void tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            throw new NotImplementedException();
        }

        public virtual void tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            throw new NotImplementedException();
        }

        public virtual void tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            throw new NotImplementedException();
        }

        public virtual void tickSize(int tickerId, int field, int size)
        {
            throw new NotImplementedException();
        }

        public virtual void tickSnapshotEnd(int tickerId)
        {
            throw new NotImplementedException();
        }

        public virtual void tickString(int tickerId, int field, string value)
        {
            throw new NotImplementedException();
        }

        public virtual void updateAccountTime(string timestamp)
        {
            throw new NotImplementedException();
        }

        public virtual void updateAccountValue(string key, string value, string currency, string accountName)
        {
            throw new NotImplementedException();
        }

        public virtual void updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            throw new NotImplementedException();
        }

        public virtual void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size, bool isSmartDepth)
        {
            throw new NotImplementedException();
        }

        public virtual void updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            throw new NotImplementedException();
        }

        public virtual void updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
        {
            throw new NotImplementedException();
        }

        public virtual void verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            throw new NotImplementedException();
        }

        public virtual void verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            throw new NotImplementedException();
        }

        public virtual void verifyCompleted(bool isSuccessful, string errorText)
        {
            throw new NotImplementedException();
        }

        public virtual void verifyMessageAPI(string apiData)
        {
            throw new NotImplementedException();
        }
    }
}
