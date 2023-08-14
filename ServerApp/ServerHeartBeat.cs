using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace Server
{
    public class ServerHeartBeat
    {
        private WebSocket webSocket;
        private string clientId;
        private ConcurrentDictionary<string, WebSocket> clientConnections;

        public ServerHeartBeat(WebSocket webSocket, string clientId, ConcurrentDictionary<string, WebSocket> clientConnections)
        {
            this.webSocket = webSocket;
            this.clientId = clientId;
            this.clientConnections = clientConnections;
        }

        public async Task StartHeartbeat()
        {
            try
            {
                Console.WriteLine("Inside the Heartbeat");



                if (webSocket.State != WebSocketState.Open)
                {

                    Console.WriteLine($"WebSocket connection with Client ID {clientId} is closed or in an error state.");
                    clientConnections.TryRemove(clientId, out _);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in WebSocket connection with Client ID {clientId}: {ex.Message}");
                clientConnections.TryRemove(clientId, out _);
            }
        }
    }
}
