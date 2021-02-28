namespace IB.Api.Client
{
    using Newtonsoft.Json;

    public partial class Paths
    {
        [JsonProperty("/ws")]
        public Tickle Ws { get; set; }

        [JsonProperty("/tickle")]
        public Tickle Tickle { get; set; }

        [JsonProperty("/logout")]
        public Logout Logout { get; set; }

        [JsonProperty("/fyi/unreadnumber")]
        public FyiUnreadnumber FyiUnreadnumber { get; set; }

        [JsonProperty("/fyi/settings")]
        public FyiSettings FyiSettings { get; set; }

        [JsonProperty("/fyi/settings/{typecode}")]
        public FyiSettingsTypecode FyiSettingsTypecode { get; set; }

        [JsonProperty("/fyi/disclaimer/{typecode}")]
        public FyiDisclaimerTypecode FyiDisclaimerTypecode { get; set; }

        [JsonProperty("/fyi/deliveryoptions")]
        public FyiDeliveryoptions FyiDeliveryoptions { get; set; }

        [JsonProperty("/fyi/deliveryoptions/email")]
        public FyiDeliveryoptionsEmail FyiDeliveryoptionsEmail { get; set; }

        [JsonProperty("/fyi/deliveryoptions/device")]
        public FyiDeliveryoptionsDevice FyiDeliveryoptionsDevice { get; set; }

        [JsonProperty("/fyi/deliveryoptions/{deviceId}")]
        public FyiDeliveryoptionsDeviceId FyiDeliveryoptionsDeviceId { get; set; }

        [JsonProperty("/fyi/notifications")]
        public FyiNotifications FyiNotifications { get; set; }

        [JsonProperty("/fyi/notifications/more")]
        public FyiNotificationsMore FyiNotificationsMore { get; set; }

        [JsonProperty("/fyi/notifications/{notificationId}")]
        public FyiNotificationsNotificationId FyiNotificationsNotificationId { get; set; }

        [JsonProperty("/iserver/auth/status")]
        public Iserver IserverAuthStatus { get; set; }

        [JsonProperty("/iserver/reauthenticate")]
        public Iserver IserverReauthenticate { get; set; }

        [JsonProperty("/iserver/account/trades")]
        public IserverAccountTrades IserverAccountTrades { get; set; }

        [JsonProperty("/iserver/accounts")]
        public IserverAccounts IserverAccounts { get; set; }

        [JsonProperty("/iserver/account")]
        public IserverAccount IserverAccount { get; set; }

        [JsonProperty("/iserver/account/{accountId}/alert")]
        public IserverAccountAccountIdAlert IserverAccountAccountIdAlert { get; set; }

        [JsonProperty("/iserver/account/:accountId/alerts")]
        public IserverAccountAccountIdAlerts IserverAccountAccountIdAlerts { get; set; }

        [JsonProperty("/iserver/account/:accountId/alert/activate")]
        public IserverAccountAccountIdAlert IserverAccountAccountIdAlertActivate { get; set; }

        [JsonProperty("/iserver/account/:accountId/alert/:alertId")]
        public IserverAccountAccountIdAlertAlertId IserverAccountAccountIdAlertAlertId { get; set; }

        [JsonProperty("/iserver/account/alert/:id")]
        public FyiNotifications IserverAccountAlertId { get; set; }

        [JsonProperty("/iserver/account/mta")]
        public FyiNotifications IserverAccountMta { get; set; }

        [JsonProperty("/iserver/account/orders")]
        public IserverAccountOrders IserverAccountOrders { get; set; }

        [JsonProperty("/iserver/account/{accountId}/order")]
        public IserverAccountOrdersFaGroupClass IserverAccountAccountIdOrder { get; set; }

        [JsonProperty("/iserver/account/{accountId}/orders")]
        public IserverAccountOrdersFaGroupClass IserverAccountAccountIdOrders { get; set; }

        [JsonProperty("/iserver/account/orders/{faGroup}")]
        public IserverAccountOrdersFaGroupClass IserverAccountOrdersFaGroup { get; set; }

        [JsonProperty("/iserver/reply/{replyid}")]
        public IserverReplyReplyid IserverReplyReplyid { get; set; }

        [JsonProperty("/iserver/account/{accountId}/order/whatif")]
        public IserverAccountAccountIdOrderWhatif IserverAccountAccountIdOrderWhatif { get; set; }

        [JsonProperty("/iserver/account/{accountId}/order/{orderId}")]
        public IserverAccountAccountIdOrderOrderId IserverAccountAccountIdOrderOrderId { get; set; }

        [JsonProperty("/iserver/marketdata/snapshot")]
        public IserverMarketdataSnapshot IserverMarketdataSnapshot { get; set; }

        [JsonProperty("/iserver/marketdata/{conid}/unsubscribe")]
        public IserverMarketdataConidUnsubscribe IserverMarketdataConidUnsubscribe { get; set; }

        [JsonProperty("/iserver/marketdata/unsubscribeall")]
        public IserverMarketdataUnsubscribeall IserverMarketdataUnsubscribeall { get; set; }

        [JsonProperty("/iserver/marketdata/history")]
        public IserverMarketdataHistory IserverMarketdataHistory { get; set; }

        [JsonProperty("/iserver/contract/{conid}/info")]
        public FyiNotifications IserverContractConidInfo { get; set; }

        [JsonProperty("/iserver/secdef/search")]
        public IserverSecdefSearch IserverSecdefSearch { get; set; }

        [JsonProperty("/iserver/secdef/strikes")]
        public IserverSecdefStrikes IserverSecdefStrikes { get; set; }

        [JsonProperty("/iserver/secdef/info")]
        public IserverSecdefInfo IserverSecdefInfo { get; set; }

        [JsonProperty("/iserver/contract/{conid}/info-and-rules")]
        public IserverContractConidInfoAndRules IserverContractConidInfoAndRules { get; set; }

        [JsonProperty("/iserver/scanner/params")]
        public IserverScannerParams IserverScannerParams { get; set; }

        [JsonProperty("/iserver/scanner/run")]
        public IserverScannerRun IserverScannerRun { get; set; }

        [JsonProperty("/iserver/account/pnl/partitioned")]
        public IserverAccountPnlPartitioned IserverAccountPnlPartitioned { get; set; }

        [JsonProperty("/trsrv/secdef")]
        public PaSummary TrsrvSecdef { get; set; }

        [JsonProperty("/trsrv/secdef/schedule")]
        public TrsrvSecdefSchedule TrsrvSecdefSchedule { get; set; }

        [JsonProperty("/trsrv/futures")]
        public Trsrv TrsrvFutures { get; set; }

        [JsonProperty("/trsrv/stocks")]
        public Trsrv TrsrvStocks { get; set; }

        [JsonProperty("/portfolio/accounts")]
        public FyiNotifications PortfolioAccounts { get; set; }

        [JsonProperty("/portfolio/subaccounts")]
        public FyiNotifications PortfolioSubaccounts { get; set; }

        [JsonProperty("/portfolio/{accountId}/meta")]
        public FyiNotifications PortfolioAccountIdMeta { get; set; }

        [JsonProperty("/portfolio/{accountId}/allocation")]
        public FyiNotifications PortfolioAccountIdAllocation { get; set; }

        [JsonProperty("/portfolio/allocation")]
        public PaSummary PortfolioAllocation { get; set; }

        [JsonProperty("/portfolio/{accountId}/positions/{pageId}")]
        public FyiNotifications PortfolioAccountIdPositionsPageId { get; set; }

        [JsonProperty("/portfolio/{accountId}/position/{conid}")]
        public FyiNotifications PortfolioAccountIdPositionConid { get; set; }

        [JsonProperty("/portfolio/{accountId}/positions/invalidate")]
        public PortfolioAccountIdPositionsInvalidate PortfolioAccountIdPositionsInvalidate { get; set; }

        [JsonProperty("/portfolio/{accountId}/summary")]
        public PortfolioAccountIdSummary PortfolioAccountIdSummary { get; set; }

        [JsonProperty("/portfolio/{accountId}/ledger")]
        public PortfolioAccountIdLedger PortfolioAccountIdLedger { get; set; }

        [JsonProperty("/portfolio/positions/{conid}")]
        public PortfolioPositionsConid PortfolioPositionsConid { get; set; }

        [JsonProperty("/sso/validate")]
        public SsoValidate SsoValidate { get; set; }

        [JsonProperty("/pa/performance")]
        public Pa PaPerformance { get; set; }

        [JsonProperty("/pa/summary")]
        public PaSummary PaSummary { get; set; }

        [JsonProperty("/pa/transactions")]
        public Pa PaTransactions { get; set; }

        [JsonProperty("/ibcust/entity/info")]
        public IbcustEntityInfo IbcustEntityInfo { get; set; }
    }
}
