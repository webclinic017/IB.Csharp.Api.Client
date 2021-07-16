using System.Collections.Generic;
using Newtonsoft.Json;

namespace IB.Api.Client.Streaming
{
    public class ConnectionHelper
    {
        public static string SubscribeToMarketDataMessage(string connectionId)
        {
            var messageFields = new MessageFields()
            {
                Fields = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }
            };
            return $"smd+{connectionId}+{JsonConvert.SerializeObject(messageFields)}";
        }
        public static string UnsubscribeFromMarketDataMessage(string connectionId)
        {
            return "umd+" + connectionId + "+{}";
        }
    }
}