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
public class ImageReceiver
{
    private const string ImageSavePath = @"C:\Users\ankit\Desktop\UploadedImages\"; 
    private IWebHost webHost;
    private CancellationTokenSource cancellationTokenSource;

    public ImageReceiver()
    {
        cancellationTokenSource = new CancellationTokenSource();
    }

    public void Start()
    {
        Console.WriteLine("inside imaage");
        webHost = new WebHostBuilder()
            .UseKestrel()
            .Configure(app =>
            {
                app.Run(async context =>
                {
                    if (context.Request.Method == "POST" && context.Request.ContentType == "image/jpeg")
                    {
                        
                        string fileName = Guid.NewGuid().ToString() + ".jpg";

                        // Read the image data from the request and save it to the server
                        using (var fileStream = new FileStream(Path.Combine(ImageSavePath, fileName), FileMode.Create))
                        {
                            await context.Request.Body.CopyToAsync(fileStream);
                        }

                      
                        Console.WriteLine($"Image received and saved successfully. File: {fileName}");

                        
                        await context.Response.WriteAsync("Image received and saved successfully.");
                    }
                    else
                    {
                        context.Response.StatusCode = 400;
                    }
                });
            })
            .Build();

        webHost.Start();
    }

    public void Stop()
    {
        cancellationTokenSource.Cancel();
        webHost?.StopAsync().Wait();
    }
   

}

