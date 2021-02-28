namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Definitions
    {
        [JsonProperty("notifications")]
        public Notifications Notifications { get; set; }

        [JsonProperty("alert-request")]
        public AlertRequest AlertRequest { get; set; }

        [JsonProperty("alert-response")]
        public AlertResponse AlertResponse { get; set; }

        [JsonProperty("authStatus")]
        public AuthStatus AuthStatus { get; set; }

        [JsonProperty("contract")]
        public Contract Contract { get; set; }

        [JsonProperty("secdef-info")]
        public SecdefInfo SecdefInfo { get; set; }

        [JsonProperty("history-data")]
        public HistoryData HistoryData { get; set; }

        [JsonProperty("trade")]
        public Trade Trade { get; set; }

        [JsonProperty("modify-order")]
        public ModifyOrder ModifyOrder { get; set; }

        [JsonProperty("order-request")]
        public OrderRequest OrderRequest { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }

        [JsonProperty("scanner-params")]
        public ScannerParams ScannerParams { get; set; }

        [JsonProperty("set-account")]
        public SetAccount SetAccount { get; set; }

        [JsonProperty("system-error")]
        public SystemError SystemError { get; set; }

        [JsonProperty("wagers")]
        public Wagers Wagers { get; set; }

        [JsonProperty("inds")]
        public Inds Inds { get; set; }

        [JsonProperty("secdef")]
        public Secdef Secdef { get; set; }

        [JsonProperty("futures")]
        public Futures Futures { get; set; }

        [JsonProperty("stocks")]
        public Stocks Stocks { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("allocation")]
        public Allocation Allocation { get; set; }

        [JsonProperty("accounts")]
        public Accounts Accounts { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("ledger")]
        public Ledger Ledger { get; set; }

        [JsonProperty("calendar_request")]
        public CalendarRequest CalendarRequest { get; set; }

        [JsonProperty("events")]
        public Events Events { get; set; }

        [JsonProperty("performance")]
        public Performance Performance { get; set; }

        [JsonProperty("transactions")]
        public DefinitionsTransactions Transactions { get; set; }

        [JsonProperty("history-result")]
        public HistoryResult HistoryResult { get; set; }

        [JsonProperty("stats-data")]
        public StatsData StatsData { get; set; }

        [JsonProperty("market-data")]
        public MarketData MarketData { get; set; }

        [JsonProperty("scanner-result")]
        public ScannerResult ScannerResult { get; set; }
    }
}
