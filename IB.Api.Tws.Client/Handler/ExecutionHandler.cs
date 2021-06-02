namespace IB.Api.Tws.Client.Handler
{
    public class ExecutionHandler
    {
        public int RequestId { get; set; }
        public Contract Contract { get; set; }
        public Execution Execution { get; set; }
        public CommissionReport CommissionReport { get; set; }
    }
}