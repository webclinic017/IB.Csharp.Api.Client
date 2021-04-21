namespace IB.Api.Tws.Client.Types
{
    public enum HistoricalDataType
    {
        //https://interactivebrokers.github.io/tws-api/historical_bars.html

        TRADES,
        MIDPOINT,
        BID,
        ASK,
        BID_ASK,
        ADJUSTED_LAST,
        HISTORICAL_VOLATILITY,
        OPTION_IMPLIED_VOLATILITY,
        REBATE_RATE,
        FEE_RATE,
        YIELD_BID,
        YIELD_ASK,
        YIELD_BID_ASK,
        YIELD_LAST
    }
}
