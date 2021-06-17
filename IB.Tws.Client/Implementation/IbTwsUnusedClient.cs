using System;
using System.Collections.Generic;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    {        
        void EWrapper.bondContractDetails(int reqId, ContractDetails contract)
        {
            throw new NotImplementedException();
        }

        void EWrapper.connectAck()
        {
            throw new NotImplementedException();
        }          

        void EWrapper.deltaNeutralValidation(int reqId, DeltaNeutralContract deltaNeutralContract)
        {
            throw new NotImplementedException();
        }

        void EWrapper.displayGroupList(int reqId, string groups)
        {
            throw new NotImplementedException();
        }

        void EWrapper.displayGroupUpdated(int reqId, string contractInfo)
        {
            throw new NotImplementedException();
        }       

        void EWrapper.familyCodes(FamilyCode[] familyCodes)
        {
            throw new NotImplementedException();
        }

        void EWrapper.fundamentalData(int reqId, string data)
        {
            throw new NotImplementedException();
        }

        void EWrapper.headTimestamp(int reqId, string headTimestamp)
        {
            throw new NotImplementedException();
        }

        void EWrapper.histogramData(int reqId, HistogramEntry[] data)
        {
            throw new NotImplementedException();
        }

        void EWrapper.historicalDataUpdate(int reqId, Bar bar)
        {
            throw new NotImplementedException();
        }

        void EWrapper.historicalNews(int requestId, string time, string providerCode, string articleId, string headline)
        {
            throw new NotImplementedException();
        }

        void EWrapper.historicalNewsEnd(int requestId, bool hasMore)
        {
            throw new NotImplementedException();
        }

        void EWrapper.historicalTicks(int reqId, HistoricalTick[] ticks, bool done)
        {
            throw new NotImplementedException();
        }

        void EWrapper.historicalTicksBidAsk(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            throw new NotImplementedException();
        }

        void EWrapper.historicalTicksLast(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            throw new NotImplementedException();
        }

        void EWrapper.managedAccounts(string accountsList)
        {
            throw new NotImplementedException();
        }

        void EWrapper.marketDataType(int reqId, int marketDataType)
        {
            throw new NotImplementedException();
        }

        void EWrapper.marketRule(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            throw new NotImplementedException();
        }

        void EWrapper.mktDepthExchanges(DepthMktDataDescription[] depthMktDataDescriptions)
        {
            throw new NotImplementedException();
        }

        void EWrapper.newsArticle(int requestId, int articleType, string articleText)
        {
            throw new NotImplementedException();
        }

        void EWrapper.newsProviders(NewsProvider[] newsProviders)
        {
            throw new NotImplementedException();
        }    

        void EWrapper.orderBound(long orderId, int apiClientId, int apiOrderId)
        {
            throw new NotImplementedException();
        }

        void EWrapper.pnl(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            throw new NotImplementedException();
        }

        void EWrapper.pnlSingle(int reqId, int pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            throw new NotImplementedException();
        }               

        void EWrapper.positionMulti(int requestId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            throw new NotImplementedException();
        }

        void EWrapper.positionMultiEnd(int requestId)
        {
            throw new NotImplementedException();
        }

        void EWrapper.realtimeBar(int reqId, long date, double open, double high, double low, double close, long volume, double WAP, int count)
        {
            throw new NotImplementedException();
        }

        void EWrapper.receiveFA(int faDataType, string faXmlData)
        {
            throw new NotImplementedException();
        }

        void EWrapper.rerouteMktDataReq(int reqId, int conId, string exchange)
        {
            throw new NotImplementedException();
        }

        void EWrapper.rerouteMktDepthReq(int reqId, int conId, string exchange)
        {
            throw new NotImplementedException();
        }

        void EWrapper.scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            throw new NotImplementedException();
        }

        void EWrapper.scannerDataEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        void EWrapper.scannerParameters(string xml)
        {
            throw new NotImplementedException();
        }

        void EWrapper.securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            throw new NotImplementedException();
        }

        void EWrapper.securityDefinitionOptionParameterEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        void EWrapper.smartComponents(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
        {
            throw new NotImplementedException();
        }

        void EWrapper.softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
            throw new NotImplementedException();
        }

        void EWrapper.symbolSamples(int reqId, ContractDescription[] contractDescriptions)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickByTickAllLast(int reqId, int tickType, long time, double price, int size, TickAttribLast tickAttriblast, string exchange, string specialConditions)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickByTickBidAsk(int reqId, long time, double bidPrice, double askPrice, int bidSize, int askSize, TickAttribBidAsk tickAttribBidAsk)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickByTickMidPoint(int reqId, long time, double midPoint)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickGeneric(int tickerId, int field, double value)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickNews(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            throw new NotImplementedException();
        }        

        void EWrapper.tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickSize(int tickerId, int field, int size)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickSnapshotEnd(int tickerId)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickString(int tickerId, int field, string value)
        {
            throw new NotImplementedException();
        }

        void EWrapper.updateAccountTime(string timestamp)
        {
            throw new NotImplementedException();
        }        

        void EWrapper.updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            throw new NotImplementedException();
        }       

        void EWrapper.updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            throw new NotImplementedException();
        }       

        void EWrapper.verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            throw new NotImplementedException();
        }

        void EWrapper.verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            throw new NotImplementedException();
        }

        void EWrapper.verifyCompleted(bool isSuccessful, string errorText)
        {
            throw new NotImplementedException();
        }

        void EWrapper.verifyMessageAPI(string apiData)
        {
            throw new NotImplementedException();
        }
    }
}
