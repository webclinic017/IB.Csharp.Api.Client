using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using IB.Api.Tws.Client.Types;
using IB.Api.Tws.Client.Handler;
using IB.Api.Tws.Client.Helper;
using System.Text.RegularExpressions;

namespace IB.Api.Tws.Client
{
    //Accounts
    public partial class IbGatewayClient
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
        public virtual void updateAccountValue(string key, string value, string currency, string accountName)
        {
            _accountUpdates.ForEach(accountUpdateHandler =>
            {
                if (accountUpdateHandler.AccountId == accountName)
                    accountUpdateHandler.AccountValues[key] = value;
            });
        }
        public virtual void accountDownloadEnd(string account)
        {
            OnUpdateAccounts?.Invoke(this, _accountUpdates);
            LogEvent($"Subscribed to account: {account} updates");
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
        public virtual void accountUpdateMulti(int reqId, string account, string modelCode, string key, string value, string currency)
        {
            _accountUpdates.ForEach(accountUpdateHandler =>
            {
                if (accountUpdateHandler.AccountId == account)
                    accountUpdateHandler.AccountValues[key] = value;
            });
        }        
        public virtual void accountUpdateMultiEnd(int requestId)
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
        public virtual void updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost, double unrealizedPNL, double realizedPNL, string accountName)
        {
            OnPortfolioUpdateReceived?.Invoke(this, new PositionHandler(contract, position, marketPrice, unrealizedPNL));
        }
        public virtual void position(string account, Contract contract, double pos, double avgCost)
        {
            OnPortfolioUpdateReceived?.Invoke(this, new PositionHandler(contract, pos, 0, 0));
        }
        public virtual void positionEnd()
        {
            LogEvent($"Positions updated");
        }        
    }
    //Market Real Time Data
    public partial class IbGatewayClient
    {
        public event EventHandler<PriceHandler> OnPriceUpdateReceived;
        public Dictionary<int, PriceHandler> Prices = new Dictionary<int, PriceHandler>();
        public void SubscribeToMarketData(Contract contract)
        {
            _clientSocket.reqMktData(contract.RequestId, contract, string.Empty, false, false, null);
            Prices[contract.RequestId] = new PriceHandler
            {
                Id = contract.RequestId,
                Symbol = contract.Symbol
            };
        }
        public void UnsubscribeFromMarketData(int id)
        {
            _clientSocket.cancelMktData(id);
        }
        public virtual void tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            var priceItem = Prices[tickerId];
            switch (field)
            {
                case TickType.BID:
                    {
                        priceItem.At = DateTime.Now;
                        priceItem.Bid = price;
                        break;
                    }
                case TickType.ASK:
                    {
                        priceItem.At = DateTime.Now;
                        priceItem.Ask = price;
                        break;
                    }
            }
            Prices[tickerId] = priceItem;
            OnPriceUpdateReceived?.Invoke(this, priceItem);
        }
    }

    //Level 2 Data
    public partial class IbGatewayClient
    {
        public event EventHandler<MarketDepthLevel2Handler> OnMarketDepthLevel2Received;

        public void RequestMarketDepth(int id, Contract contract)
        {
            _clientSocket.reqMarketDepth(id, contract, 5, true, null);
        }
        public virtual void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size, bool isSmartDepth)
        {
            var data = new MarketDepthLevel2Handler
            {
                At = DateTime.Now,
                TickerId = tickerId,
                Position = position,
                MarketMaker = marketMaker,
                Operation = operation,
                Side = side,
                Price = price,
                Size = size,
                IsSmartDepth = isSmartDepth
            };
            OnMarketDepthLevel2Received?.Invoke(this, data);
        }
    }

    //Historical Data
    public partial class IbGatewayClient
    {
        public event EventHandler<HistoricalDataHandler> OnHistoricalDataReceived;
        public event EventHandler<string> OnHistoricalEnd;
        public void RequestHistoricalData(DateTime to, Contract contract, int duration, DurationUnit durationUnit, int barSize, BarSizeUnit barSizeUnit, HistoricalDataType historicalDataType)
        {
            string endDate = to.ToString("yyyyMMdd HH:mm:ss");
            _clientSocket.reqHistoricalData(contract.RequestId, contract, endDate, $"{duration} {durationUnit}", $"{barSize} {barSizeUnit}", historicalDataType.ToString(), 0, 1, false, null);
        }
        public virtual void historicalData(int reqId, Bar bar)
        {
            var historicalDataHandler = new HistoricalDataHandler
            {
                RequestId = reqId,
                BarData = bar
            };
            OnHistoricalDataReceived?.Invoke(this, historicalDataHandler);
        }
        public virtual void historicalDataEnd(int reqId, string startDate, string endDate)
        {
            OnHistoricalEnd?.Invoke(this, "HistoricalDataEnd - " + reqId + " from " + startDate + " to " + endDate);
        }
    }

    //Orders
    public partial class IbGatewayClient
    {
        public event EventHandler<OpenOrderHandler> OnOpenOrderUpdateReceived;
        public event EventHandler<OrderStatusHandler> OnOrderStatusReceived;
        public void RequestCompletedOrders()
        {
            _clientSocket.reqCompletedOrders(true);
        }        
        public void OpenMarketOrder(OrderSide side, Contract contract, double quantity)
        {
            _clientSocket.placeOrder(NextOrderId++, contract, OrderHelper.MarketOrder(side, quantity));
        }
        public void PreviewMarketOrder(OrderSide side, Contract contract, double quantity)
        {
            _clientSocket.placeOrder(NextOrderId++, contract, OrderHelper.WhatIfMarketOrder(side, quantity));
        }
        public virtual void orderStatus(int orderId, string status, double filled, double remaining, double avgFillPrice, int permId, int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            var orderStatusHandler = new OrderStatusHandler
            {
                OrderId = orderId,
                Status = status,
                Filled = filled,
                Remaining = remaining,
                AvgFillPrice = avgFillPrice,
                PermId = permId,
                ParentId = parentId,
                LastFillPrice = lastFillPrice,
                ClientId = clientId,
                WhyHeld = whyHeld,
                MktCapPrice = mktCapPrice
            };
            OnOrderStatusReceived?.Invoke(this, orderStatusHandler);
        }
        public virtual void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            var openOrder = new OpenOrderHandler
            {
                OrderId = orderId,
                Contract = contract,
                Order = order,
                OrderState = orderState
            };
            OnOpenOrderUpdateReceived?.Invoke(this, openOrder);
        }
        public virtual void openOrderEnd() { }
        public virtual void completedOrder(Contract contract, Order order, OrderState orderState)
        {
            var orderStatusHandler = new OrderStatusHandler
            {
                Status = orderState.Status,
                PermId = order.PermId
            };
            OnOrderStatusReceived?.Invoke(this, orderStatusHandler);
        }
        public virtual void completedOrdersEnd() { }
    }

    //Contracts
    public partial class IbGatewayClient
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
        public virtual void contractDetails(int reqId, ContractDetails contractDetails)
        {
            _contractDetailsList.Add(contractDetails);
        }
        public virtual void contractDetailsEnd(int reqId)
        {
            OnContractDetailsReceived?.Invoke(this, _contractDetailsList);
        }
    }
    //Executions
    public partial class IbGatewayClient
    {
        public event EventHandler<ExecutionHandler> OnExecutionUpdateReceived;
        private Contract _contract;
        private Execution _execution;
        private CommissionReport _commissionReport;
        public void RequestExecutions()
        {
            _clientSocket.reqExecutions(10001, new ExecutionFilter());
        }
        public virtual void execDetails(int reqId, Contract contract, Execution execution)
        {
            _contract = contract;
            _execution = execution;
        }
        public virtual void commissionReport(CommissionReport commissionReport)
        {
            _commissionReport = commissionReport;
        }
        public virtual void execDetailsEnd(int reqId)
        {
            var executionHandler = new ExecutionHandler
            {
                RequestId = reqId,
                Contract = _contract,
                Execution = _execution,
                CommissionReport = _commissionReport
            };

            OnExecutionUpdateReceived?.Invoke(this, executionHandler);
        }                
    }

    public partial class IbGatewayClient : EWrapper
    {
        private readonly EReaderSignal _signal;
        private EClientSocket _clientSocket;
        private int NextOrderId;
        public string BboExchange { get; set; }

        public event EventHandler<string> OnLogReceived;

        public IbGatewayClient(string address, int port, int clientId)
        {
            _signal = new EReaderMonitorSignal();
            _clientSocket = new EClientSocket(this, _signal);

            _clientSocket.eConnect(address, port, clientId);
            var reader = new EReader(_clientSocket, _signal);
            reader.Start();
            new Thread(() =>
            {
                while (_clientSocket.IsConnected())
                {
                    _signal.waitForSignal();
                    reader.processMsgs();
                }
            })
            { IsBackground = true }.Start();
        }
        private void LogEvent(string message)
        {
            message = $"{DateTime.Now.ToString()} | {message}";
            OnLogReceived?.Invoke(this, message);
            Console.WriteLine(message);
        }
        public void Disconnect()
        {
            _clientSocket.eDisconnect();
        }

        public virtual void error(Exception e)
        {
            LogEvent("Exception thrown: " + e);
            throw e;
        }
        public virtual void error(string str)
        {
            LogEvent("Error: " + str + "\n");
        }
        public virtual void error(int id, int errorCode, string errorMsg)
        {
            if (id == -1) LogEvent("Code: " + errorCode + ", Msg: " + errorMsg);
            else LogEvent("Error. Id: " + id + ", Code: " + errorCode + ", Msg: " + errorMsg);
        }
        public virtual void connectionClosed()
        {
            LogEvent("Connection closed.\n");
        }

        public virtual void currentTime(long time)
        {
            LogEvent("Current Time: " + time + "\n");
        }
        public virtual void nextValidId(int orderId)
        {
            LogEvent("Next Valid Id: " + orderId);
            NextOrderId = orderId;
        }
        public virtual void deltaNeutralValidation(int reqId, DeltaNeutralContract deltaNeutralContract)
        {
            LogEvent("DeltaNeutralValidation. " + reqId + ", ConId: " + deltaNeutralContract.ConId + ", Delta: " + deltaNeutralContract.Delta + ", Price: " + deltaNeutralContract.Price);
        }
        public virtual void managedAccounts(string accountsList)
        {
            LogEvent("Account list: " + accountsList);
        }
        public virtual void tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            LogEvent("TickOptionComputation. TickerId: " + tickerId + ", field: " + field + ", ImpliedVolatility: " + impliedVolatility + ", Delta: " + delta
                + ", OptionPrice: " + optPrice + ", pvDividend: " + pvDividend + ", Gamma: " + gamma + ", Vega: " + vega + ", Theta: " + theta + ", UnderlyingPrice: " + undPrice);
        }
        public virtual void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            LogEvent("Acct Summary. ReqId: " + reqId + ", Acct: " + account + ", Tag: " + tag + ", Value: " + value + ", Currency: " + currency);
        }
        public virtual void accountSummaryEnd(int reqId)
        {
            LogEvent("AccountSummaryEnd. Req Id: " + reqId + "\n");
        }        
        public virtual void fundamentalData(int reqId, string data)
        {
            LogEvent("FundamentalData. " + reqId + "" + data + "\n");
        }
        public virtual void marketDataType(int reqId, int marketDataType)
        {
            LogEvent("MarketDataType. " + reqId + ", Type: " + marketDataType + "\n");
        }
        public virtual void updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            LogEvent("UpdateMarketDepth. " + tickerId + " - Position: " + position + ", Operation: " + operation + ", Side: " + side + ", Price: " + price + ", Size: " + size);
        }
        public virtual void updateNewsBulletin(int msgId, int msgType, String message, String origExchange)
        {
            LogEvent("News Bulletins. " + msgId + " - Type: " + msgType + ", Message: " + message + ", Exchange of Origin: " + origExchange + "\n");
        }

        public virtual void realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume, double WAP, int count)
        {
            LogEvent("RealTimeBars. " + reqId + " - Time: " + time + ", Open: " + open + ", High: " + high + ", Low: " + low + ", Close: " + close + ", Volume: " + volume + ", Count: " + count + ", WAP: " + WAP);
        }
        public virtual void scannerParameters(string xml)
        {
            LogEvent("ScannerParameters. " + xml + "\n");
        }
        public virtual void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            LogEvent("ScannerData. " + reqId + " - Rank: " + rank + ", Symbol: " + contractDetails.Contract.Symbol + ", SecType: " + contractDetails.Contract.SecType + ", Currency: " + contractDetails.Contract.Currency
                + ", Distance: " + distance + ", Benchmark: " + benchmark + ", Projection: " + projection + ", Legs String: " + legsStr);
        }
        public virtual void scannerDataEnd(int reqId)
        {
            LogEvent("ScannerDataEnd. " + reqId);
        }
        public virtual void receiveFA(int faDataType, string faXmlData)
        {
            LogEvent("Receing FA: " + faDataType + " - " + faXmlData);
        }
        public virtual void bondContractDetails(int requestId, ContractDetails contractDetails)
        {
            LogEvent("BondContractDetails begin. ReqId: " + requestId);
            LogEvent("BondContractDetails end. ReqId: " + requestId);
        }
        public virtual void verifyMessageAPI(string apiData)
        {
            LogEvent("verifyMessageAPI: " + apiData);
        }
        public virtual void verifyCompleted(bool isSuccessful, string errorText)
        {
            LogEvent("verifyCompleted. IsSuccessfule: " + isSuccessful + " - Error: " + errorText);
        }
        public virtual void verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            LogEvent("verifyAndAuthMessageAPI: " + apiData + " " + xyzChallenge);
        }
        public virtual void verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            LogEvent("verifyAndAuthCompleted. IsSuccessful: " + isSuccessful + " - Error: " + errorText);
        }
        public virtual void displayGroupList(int reqId, string groups)
        {
            LogEvent("DisplayGroupList. Request: " + reqId + ", Groups" + groups);
        }
        public virtual void displayGroupUpdated(int reqId, string contractInfo)
        {
            LogEvent("displayGroupUpdated. Request: " + reqId + ", ContractInfo: " + contractInfo);
        }
        public virtual void positionMulti(int reqId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            LogEvent("Position Multi. Request: " + reqId + ", Account: " + account + ", ModelCode: " + modelCode + ", Symbol: " + contract.Symbol + ", SecType: " + contract.SecType + ", Currency: " + contract.Currency + ", Position: " + pos + ", Avg cost: " + avgCost + "\n");
        }
        public virtual void positionMultiEnd(int reqId)
        {
            LogEvent("Position Multi End. Request: " + reqId + "\n");
        }
        public void securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            LogEvent($"Security Definition Option Parameter. Reqest: {reqId}, Exchange: {exchange}, Undrelying contract id: {underlyingConId}, Trading class: {tradingClass}, Multiplier: {multiplier}, Expirations: {string.Join(", ", expirations)}, Strikes: {string.Join(", ", strikes)}");
        }
        public void securityDefinitionOptionParameterEnd(int reqId)
        {
            LogEvent("Security Definition Option Parameter End. Request: " + reqId + "\n");
        }
        public void connectAck()
        {
            if (_clientSocket.AsyncEConnect)
                _clientSocket.startApi();
        }
        public void softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
            LogEvent("Soft Dollar Tiers:");

            foreach (var tier in tiers)
            {
                LogEvent(tier.DisplayName);
            }
        }
        public void familyCodes(FamilyCode[] familyCodes)
        {
            LogEvent("Family Codes:");

            foreach (var familyCode in familyCodes)
            {
                LogEvent($"Account ID: {familyCode.AccountID}, Family Code Str: {familyCode.FamilyCodeStr}");
            }
        }
        public void symbolSamples(int reqId, ContractDescription[] contractDescriptions)
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
        public void mktDepthExchanges(DepthMktDataDescription[] depthMktDataDescriptions)
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
        public void tickNews(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            LogEvent(string.Format("Tick News. Ticker Id: {0}, Time Stamp: {1}, Provider Code: {2}, Article Id: {3}, headline: {4}, extraData: {5}", tickerId, timeStamp, providerCode, articleId, headline, extraData));
        }
        public void smartComponents(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
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
        public void tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            LogEvent($"id={tickerId} minTick = {minTick} bboExchange = {bboExchange} snapshotPermissions = {snapshotPermissions}");

            BboExchange = bboExchange;
        }
        public void newsProviders(NewsProvider[] newsProviders)
        {
            LogEvent("News Providers:");

            foreach (var newsProvider in newsProviders)
            {
                LogEvent($"News provider: providerCode - {newsProvider.ProviderCode}, providerName - {newsProvider.ProviderName}");
            }
        }
        public void newsArticle(int requestId, int articleType, string articleText)
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
        public void historicalNews(int requestId, string time, string providerCode, string articleId, string headline)
        {
            LogEvent(string.Format("Historical News. Request Id: {0}, Time: {1}, Provider Code: {2}, Article Id: {3}, headline: {4}", requestId, time, providerCode, articleId, headline));
        }
        public void historicalNewsEnd(int requestId, bool hasMore)
        {
            LogEvent(string.Format("Historical News End. Request Id: {0}, Has More: {1}", requestId, hasMore));
        }
        public void headTimestamp(int reqId, string headTimestamp)
        {
            LogEvent(string.Format("Head time stamp. Request Id: {0}, Head time stamp: {1}", reqId, headTimestamp));
        }
        public void histogramData(int reqId, HistogramEntry[] data)
        {
            LogEvent(string.Format("Histogram data. Request Id: {0}, data size: {1}", reqId, data.Length));
            data.ToList().ForEach(i => LogEvent(string.Format("\tPrice: {0}, Size: {1}", i.Price, i.Size)));
        }
        public void historicalDataUpdate(int reqId, Bar bar)
        {
            LogEvent("HistoricalDataUpdate. " + reqId + " - Time: " + bar.Time + ", Open: " + bar.Open + ", High: " + bar.High + ", Low: " + bar.Low + ", Close: " + bar.Close + ", Volume: " + bar.Volume + ", Count: " + bar.Count + ", WAP: " + bar.WAP);
        }
        public void rerouteMktDataReq(int reqId, int conId, string exchange)
        {
            LogEvent(string.Format("Re-route market data request. Req Id: {0}, ConId: {1}, Exchange: {2}", reqId, conId, exchange));
        }
        public void rerouteMktDepthReq(int reqId, int conId, string exchange)
        {
            LogEvent(string.Format("Re-route market depth request. Req Id: {0}, ConId: {1}, Exchange: {2}", reqId, conId, exchange));
        }
        public void marketRule(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            LogEvent("Market Rule Id: " + marketRuleId);
            foreach (var priceIncrement in priceIncrements)
            {
                LogEvent(string.Format("Low Edge: {0}, Increment: {1}", ((decimal)priceIncrement.LowEdge).ToString(), ((decimal)priceIncrement.Increment).ToString()));
            }
        }
        public void pnl(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            LogEvent(string.Format("PnL. Request Id: {0}, Daily PnL: {1}, Unrealized PnL: {2}, Realized PnL: {3}", reqId, dailyPnL, unrealizedPnL, realizedPnL));
        }
        public void pnlSingle(int reqId, int pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            LogEvent(string.Format("PnL Single. Request Id: {0}, Pos {1}, Daily PnL {2}, Unrealized PnL {3}, Realized PnL: {4}, Value: {5}", reqId, pos, dailyPnL, unrealizedPnL, realizedPnL, value));
        }
        public void historicalTicks(int reqId, HistoricalTick[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                LogEvent(string.Format("Historical Tick. Request Id: {0}, Time: {1}, Price: {2}, Size: {3}", reqId, Util.UnixSecondsToString(tick.Time, "yyyyMMdd-HH:mm:ss zzz"), tick.Price, tick.Size));
            }
        }
        public void historicalTicksBidAsk(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                LogEvent(string.Format("Historical Tick Bid/Ask. Request Id: {0}, Time: {1}, Price Bid: {2}, Price Ask: {3}, Size Bid: {4}, Size Ask: {5}, Bid/Ask Tick Attribs: {6} ",
                    reqId, Util.UnixSecondsToString(tick.Time, "yyyyMMdd-HH:mm:ss zzz"), tick.PriceBid, tick.PriceAsk, tick.SizeBid, tick.SizeAsk, tick.TickAttribBidAsk.toString()));
            }
        }
        public void historicalTicksLast(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                LogEvent(string.Format("Historical Tick Last. Request Id: {0}, Time: {1}, Price: {2}, Size: {3}, Exchange: {4}, Special Conditions: {5}, Last Tick Attribs: {6} ",
                    reqId, Util.UnixSecondsToString(tick.Time, "yyyyMMdd-HH:mm:ss zzz"), tick.Price, tick.Size, tick.Exchange, tick.SpecialConditions, tick.TickAttribLast.toString()));
            }
        }
        public void tickByTickAllLast(int reqId, int tickType, long time, double price, int size, TickAttribLast tickAttribLast, string exchange, string specialConditions)
        {
            LogEvent(string.Format("Tick-By-Tick. Request Id: {0}, TickType: {1}, Time: {2}, Price: {3}, Size: {4}, Exchange: {5}, Special Conditions: {6}, PastLimit: {7}, Unreported: {8}",
                reqId, tickType == 1 ? "Last" : "AllLast", Util.UnixSecondsToString(time, "yyyyMMdd-HH:mm:ss zzz"), price, size, exchange, specialConditions, tickAttribLast.PastLimit, tickAttribLast.Unreported));
        }
        public void tickByTickBidAsk(int reqId, long time, double bidPrice, double askPrice, int bidSize, int askSize, TickAttribBidAsk tickAttribBidAsk)
        {
            LogEvent(string.Format("Tick-By-Tick. Request Id: {0}, TickType: BidAsk, Time: {1}, BidPrice: {2}, AskPrice: {3}, BidSize: {4}, AskSize: {5}, BidPastLow: {6}, AskPastHigh: {7}",
                reqId, Util.UnixSecondsToString(time, "yyyyMMdd-HH:mm:ss zzz"), bidPrice, askPrice, bidSize, askSize, tickAttribBidAsk.BidPastLow, tickAttribBidAsk.AskPastHigh));
        }
        public void tickByTickMidPoint(int reqId, long time, double midPoint)
        {
            LogEvent(string.Format("Tick-By-Tick. Request Id: {0}, TickType: MidPoint, Time: {1}, MidPoint: {2}",
                reqId, Util.UnixSecondsToString(time, "yyyyMMdd-HH:mm:ss zzz"), midPoint));
        }
        public void orderBound(long orderId, int apiClientId, int apiOrderId)
        {
            LogEvent(string.Format("Order bound. Order Id: {0}, Api Client Id: {1}, Api Order Id: {2}", orderId, apiClientId, apiOrderId));
        }

        
        public virtual void updateAccountTime(string timestamp)
        {
        }
        
        public virtual void tickSize(int tickerId, int field, int size)
        {
            //LogEvent("Tick Size. Ticker Id:" + tickerId + ", Field: " + field + ", Size: " + size);
        }
        public virtual void tickString(int tickerId, int tickType, string value)
        {
            //LogEvent("Tick string. Ticker Id:" + tickerId + ", Type: " + tickType + ", Value: " + value);
        }
        public virtual void tickGeneric(int tickerId, int field, double value)
        {
            //LogEvent("Tick Generic. Ticker Id:" + tickerId + ", Field: " + field + ", Value: " + value);
        }
        public virtual void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            //LogEvent("TickEFP. "+tickerId+", Type: "+tickType+", BasisPoints: "+basisPoints+", FormattedBasisPoints: "+formattedBasisPoints+", ImpliedFuture: "+impliedFuture+", HoldDays: "+holdDays+", FutureLastTradeDate: "+futureLastTradeDate+", DividendImpact: "+dividendImpact+", DividendsToLastTradeDate: "+dividendsToLastTradeDate);
        }
        public virtual void tickSnapshotEnd(int tickerId)
        {
            //LogEvent("TickSnapshotEnd: "+tickerId);
        }
    }
}