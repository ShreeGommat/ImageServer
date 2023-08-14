using System;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace Server
{
    public class ServerApp
    {
        private HttpListener httpListener;
        private CancellationTokenSource cancellationTokenSource;
        private ConcurrentDictionary<string, WebSocket> clientConnections;

        public ServerApp(string ipAddress, int port)
        {

            clientConnections = new ConcurrentDictionary<string, WebSocket>();
            httpListener = new HttpListener();
            httpListener.Prefixes.Add($"http://{ipAddress}:{port}/");
            cancellationTokenSource = new CancellationTokenSource();
        }

        public void Start()
        {
            httpListener.Start();
            AcceptWebSocketConnections();
        }

        public void Stop()
        {
            cancellationTokenSource.Cancel();
            httpListener.Stop();
        }

        private async void AcceptWebSocketConnections()
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                try
                {
                    HttpListenerContext context = await httpListener.GetContextAsync();
                    if (context.Request.IsWebSocketRequest)
                    {
                        ProcessWebSocketRequest(context);
                    }
                    else
                    {
                        context.Response.StatusCode = 400;
                        context.Response.Close();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }
            }
        }

        private async void ProcessWebSocketRequest(HttpListenerContext context)
        {
            try
            {
                HttpListenerWebSocketContext webSocketContext = await context.AcceptWebSocketAsync(subProtocol: null);
                WebSocket webSocket = webSocketContext.WebSocket;

                //Add the WebSocket 
                string clientId = Guid.NewGuid().ToString();
                clientConnections[clientId] = webSocket;


                var heartbeat = new ServerHeartBeat(webSocket, clientId, clientConnections);
                await heartbeat.StartHeartbeat();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}

