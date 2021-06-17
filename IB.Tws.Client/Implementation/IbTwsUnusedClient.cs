using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IB.Tws.Client.Implementation
{
    public partial class IbTwsClient : EWrapper
    {        
        void EWrapper.bondContractDetails(int reqId, ContractDetails contract)
        {
            LogEvent("BondContractDetails begin. ReqId: " + reqId);
            LogEvent("BondContractDetails end. ReqId: " + reqId);
        }                 

        void EWrapper.deltaNeutralValidation(int reqId, DeltaNeutralContract deltaNeutralContract)
        {
            LogEvent("DeltaNeutralValidation. " + reqId + ", ConId: " + deltaNeutralContract.ConId + ", Delta: " + deltaNeutralContract.Delta + ", Price: " + deltaNeutralContract.Price);
        }

        void EWrapper.displayGroupList(int reqId, string groups)
        {
            LogEvent("DisplayGroupList. Request: " + reqId + ", Groups" + groups);
        }

        void EWrapper.displayGroupUpdated(int reqId, string contractInfo)
        {
            LogEvent("displayGroupUpdated. Request: " + reqId + ", ContractInfo: " + contractInfo);
        }   

        void EWrapper.familyCodes(FamilyCode[] familyCodes)
        {
            LogEvent("Family Codes:");

            foreach (var familyCode in familyCodes)
            {
                LogEvent($"Account ID: {familyCode.AccountID}, Family Code Str: {familyCode.FamilyCodeStr}");
            }
        }

        void EWrapper.fundamentalData(int reqId, string data)
        {
            LogEvent("FundamentalData. " + reqId + "" + data + "\n");
        }

        void EWrapper.headTimestamp(int reqId, string headTimestamp)
        {
            LogEvent(string.Format("Head time stamp. Request Id: {0}, Head time stamp: {1}", reqId, headTimestamp));
        }

        void EWrapper.histogramData(int reqId, HistogramEntry[] data)
        {
            LogEvent(string.Format("Histogram data. Request Id: {0}, data size: {1}", reqId, data.Length));
            data.ToList().ForEach(i => LogEvent(string.Format("\tPrice: {0}, Size: {1}", i.Price, i.Size)));
        }

        void EWrapper.historicalDataUpdate(int reqId, Bar bar)
        {
            LogEvent("HistoricalDataUpdate. " + reqId + " - Time: " + bar.Time + ", Open: " + bar.Open + ", High: " + bar.High + ", Low: " + bar.Low + ", Close: " + bar.Close + ", Volume: " + bar.Volume + ", Count: " + bar.Count + ", WAP: " + bar.WAP);
        }

        void EWrapper.historicalNews(int requestId, string time, string providerCode, string articleId, string headline)
        {
            LogEvent(string.Format("Historical News. Request Id: {0}, Time: {1}, Provider Code: {2}, Article Id: {3}, headline: {4}", requestId, time, providerCode, articleId, headline));
        }

        void EWrapper.historicalNewsEnd(int requestId, bool hasMore)
        {
            LogEvent(string.Format("Historical News End. Request Id: {0}, Has More: {1}", requestId, hasMore));
        }

        void EWrapper.historicalTicks(int reqId, HistoricalTick[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                LogEvent(string.Format("Historical Tick. Request Id: {0}, Time: {1}, Price: {2}, Size: {3}", reqId, Util.UnixSecondsToString(tick.Time, "yyyyMMdd-HH:mm:ss zzz"), tick.Price, tick.Size));
            }
        }

        void EWrapper.historicalTicksBidAsk(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                LogEvent(string.Format("Historical Tick Bid/Ask. Request Id: {0}, Time: {1}, Price Bid: {2}, Price Ask: {3}, Size Bid: {4}, Size Ask: {5}, Bid/Ask Tick Attribs: {6} ",
                    reqId, Util.UnixSecondsToString(tick.Time, "yyyyMMdd-HH:mm:ss zzz"), tick.PriceBid, tick.PriceAsk, tick.SizeBid, tick.SizeAsk, tick.TickAttribBidAsk.toString()));
            }
        }

        void EWrapper.historicalTicksLast(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                LogEvent(string.Format("Historical Tick Last. Request Id: {0}, Time: {1}, Price: {2}, Size: {3}, Exchange: {4}, Special Conditions: {5}, Last Tick Attribs: {6} ",
                    reqId, Util.UnixSecondsToString(tick.Time, "yyyyMMdd-HH:mm:ss zzz"), tick.Price, tick.Size, tick.Exchange, tick.SpecialConditions, tick.TickAttribLast.toString()));
            }
        }

        void EWrapper.managedAccounts(string accountsList)
        {
            LogEvent("Account list: " + accountsList);
        }

        void EWrapper.marketDataType(int reqId, int marketDataType)
        {
            LogEvent("MarketDataType. " + reqId + ", Type: " + marketDataType + "\n");
        }

        void EWrapper.marketRule(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            LogEvent("Market Rule Id: " + marketRuleId);
            foreach (var priceIncrement in priceIncrements)
            {
                LogEvent(string.Format("Low Edge: {0}, Increment: {1}", ((decimal)priceIncrement.LowEdge).ToString(), ((decimal)priceIncrement.Increment).ToString()));
            }
        }

        void EWrapper.mktDepthExchanges(DepthMktDataDescription[] depthMktDataDescriptions)
        {
            LogEvent("Market Depth Exchanges:");

            foreach (var depthMktDataDescription in depthMktDataDescriptions)
            {
                LogEvent(string.Format("Depth Market Data Description: Exchange: {0}, Security Type: {1}, Listing Exch: {2}, Service Data Type: {3}, Agg Group: {4}",
                    depthMktDataDescription.Exchange, depthMktDataDescription.SecType,
                    depthMktDataDescription.ListingExch, depthMktDataDescription.ServiceDataType,
                    depthMktDataDescription.AggGroup != Int32.MaxValue ? depthMktDataDescription.AggGroup.ToString() : ""
                    ));
            }
        }

        void EWrapper.newsArticle(int requestId, int articleType, string articleText)
        {
            LogEvent(string.Format("News Article. Request Id: {0}, ArticleType: {1}", requestId, articleType));
            if (articleType == 0)
            {
                LogEvent(string.Format("News Article Text: {0}", articleText));
            }
            else if (articleType == 1)
            {
                LogEvent("News Article Text: article text is binary/pdf and cannot be displayed");
            }
        }

        void EWrapper.newsProviders(NewsProvider[] newsProviders)
        {
             LogEvent("News Providers:");

            foreach (var newsProvider in newsProviders)
            {
                LogEvent($"News provider: providerCode - {newsProvider.ProviderCode}, providerName - {newsProvider.ProviderName}");
            }
        } 

        void EWrapper.orderBound(long orderId, int apiClientId, int apiOrderId)
        {
            LogEvent(string.Format("Order bound. Order Id: {0}, Api Client Id: {1}, Api Order Id: {2}", orderId, apiClientId, apiOrderId));
        }

        void EWrapper.pnl(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            LogEvent(string.Format("PnL. Request Id: {0}, Daily PnL: {1}, Unrealized PnL: {2}, Realized PnL: {3}", reqId, dailyPnL, unrealizedPnL, realizedPnL));
        }

        void EWrapper.pnlSingle(int reqId, int pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            LogEvent(string.Format("PnL Single. Request Id: {0}, Pos {1}, Daily PnL {2}, Unrealized PnL {3}, Realized PnL: {4}, Value: {5}", reqId, pos, dailyPnL, unrealizedPnL, realizedPnL, value));
        }            

        void EWrapper.positionMulti(int requestId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            throw new NotImplementedException();
        }

        void EWrapper.positionMultiEnd(int requestId)
        {
            LogEvent("Position Multi End. Request: " + requestId + "\n");
        }

        void EWrapper.realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume, double WAP, int count)
        {
            LogEvent("RealTimeBars. " + reqId + " - Time: " + time + ", Open: " + open + ", High: " + high + ", Low: " + low + ", Close: " + close + ", Volume: " + volume + ", Count: " + count + ", WAP: " + WAP);
        }

        void EWrapper.receiveFA(int faDataType, string faXmlData)
        {
            LogEvent("Receing FA: " + faDataType + " - " + faXmlData);
        }

        void EWrapper.rerouteMktDataReq(int reqId, int conId, string exchange)
        {
            LogEvent(string.Format("Re-route market data request. Req Id: {0}, ConId: {1}, Exchange: {2}", reqId, conId, exchange));
        }

        void EWrapper.rerouteMktDepthReq(int reqId, int conId, string exchange)
        {
            LogEvent(string.Format("Re-route market depth request. Req Id: {0}, ConId: {1}, Exchange: {2}", reqId, conId, exchange));
        }

        void EWrapper.scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            LogEvent("ScannerData. " + reqId + " - Rank: " + rank + ", Symbol: " + contractDetails.Contract.Symbol + ", SecType: " + contractDetails.Contract.SecType + ", Currency: " + contractDetails.Contract.Currency
                + ", Distance: " + distance + ", Benchmark: " + benchmark + ", Projection: " + projection + ", Legs String: " + legsStr);
        }

        void EWrapper.scannerDataEnd(int reqId)
        {
            LogEvent("ScannerDataEnd. " + reqId);
        }

        void EWrapper.scannerParameters(string xml)
        {
            LogEvent("ScannerParameters. " + xml + "\n");
        }

        void EWrapper.securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            LogEvent($"Security Definition Option Parameter. Reqest: {reqId}, Exchange: {exchange}, Undrelying contract id: {underlyingConId}, Trading class: {tradingClass}, Multiplier: {multiplier}, Expirations: {string.Join(", ", expirations)}, Strikes: {string.Join(", ", strikes)}");
        }

        void EWrapper.securityDefinitionOptionParameterEnd(int reqId)
        {
            LogEvent("Security Definition Option Parameter End. Request: " + reqId + "\n");
        }

        void EWrapper.smartComponents(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("==== Smart Components Begin (total={0}) reqId = {1} ====\n", theMap.Count, reqId);

            foreach (var item in theMap)
            {
                sb.AppendFormat("bit number: {0}, exchange: {1}, exchange letter: {2}\n", item.Key, item.Value.Key, item.Value.Value);
            }

            sb.AppendFormat("==== Smart Components Begin (total={0}) reqId = {1} ====\n", theMap.Count, reqId);

            LogEvent(sb.ToString());
        }

        void EWrapper.softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
            LogEvent("Soft Dollar Tiers:");

            foreach (var tier in tiers)
            {
                LogEvent(tier.DisplayName);
            }
        }

        void EWrapper.symbolSamples(int reqId, ContractDescription[] contractDescriptions)
        {
            string derivSecTypes;
            LogEvent($"Symbol Samples. Request Id: {reqId}");

            foreach (var contractDescription in contractDescriptions)
            {
                derivSecTypes = "";
                foreach (var derivSecType in contractDescription.DerivativeSecTypes)
                {
                    derivSecTypes += derivSecType;
                    derivSecTypes += " ";
                }
                LogEvent(string.Format("Contract: conId - {0}, symbol - {1}, secType - {2}, primExchange - {3}, currency - {4}, derivativeSecTypes - {5}",
                    contractDescription.Contract.ConId, contractDescription.Contract.Symbol, contractDescription.Contract.SecType,
                    contractDescription.Contract.PrimaryExch, contractDescription.Contract.Currency, derivSecTypes));
            }
        }

        void EWrapper.tickByTickAllLast(int reqId, int tickType, long time, double price, int size, TickAttribLast tickAttriblast, string exchange, string specialConditions)
        {
            throw new NotImplementedException();
        }

        void EWrapper.tickByTickBidAsk(int reqId, long time, double bidPrice, double askPrice, int bidSize, int askSize, TickAttribBidAsk tickAttribBidAsk)
        {
            LogEvent(string.Format("Tick-By-Tick. Request Id: {0}, TickType: BidAsk, Time: {1}, BidPrice: {2}, AskPrice: {3}, BidSize: {4}, AskSize: {5}, BidPastLow: {6}, AskPastHigh: {7}",
                reqId, Util.UnixSecondsToString(time, "yyyyMMdd-HH:mm:ss zzz"), bidPrice, askPrice, bidSize, askSize, tickAttribBidAsk.BidPastLow, tickAttribBidAsk.AskPastHigh));
        }

        void EWrapper.tickByTickMidPoint(int reqId, long time, double midPoint)
        {
            LogEvent(string.Format("Tick-By-Tick. Request Id: {0}, TickType: MidPoint, Time: {1}, MidPoint: {2}",
                reqId, Util.UnixSecondsToString(time, "yyyyMMdd-HH:mm:ss zzz"), midPoint));
        }

        void EWrapper.tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            
        }

        void EWrapper.tickGeneric(int tickerId, int field, double value)
        {
            
        }

        void EWrapper.tickNews(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            
        }

        void EWrapper.tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            
        }        

        void EWrapper.tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            
        }

        void EWrapper.tickSize(int tickerId, int field, int size)
        {
            
        }

        void EWrapper.tickSnapshotEnd(int tickerId)
        {
            
        }

        void EWrapper.tickString(int tickerId, int field, string value)
        {
            
        }

        void EWrapper.updateAccountTime(string timestamp)
        {
            
        }        

        void EWrapper.updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            LogEvent("UpdateMarketDepth. " + tickerId + " - Position: " + position + ", Operation: " + operation + ", Side: " + side + ", Price: " + price + ", Size: " + size);
        }   

        void EWrapper.updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            LogEvent("News Bulletins. " + msgId + " - Type: " + msgType + ", Message: " + message + ", Exchange of Origin: " + origExchange + "\n");
        }   

        void EWrapper.verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            LogEvent("verifyAndAuthCompleted. IsSuccessful: " + isSuccessful + " - Error: " + errorText);
        }

        void EWrapper.verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            LogEvent("verifyAndAuthMessageAPI: " + apiData + " " + xyzChallenge);
        }

        void EWrapper.verifyCompleted(bool isSuccessful, string errorText)
        {
            LogEvent("verifyCompleted. IsSuccessfule: " + isSuccessful + " - Error: " + errorText);
        }

        void EWrapper.verifyMessageAPI(string apiData)
        {
            LogEvent("verifyMessageAPI: " + apiData);
        }
    }
}
