using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            
            string ipAddress = "127.0.0.1"; 
            int port = 8085;
            var serverApp = new ServerApp(ipAddress, port);
            serverApp.Start();

            
            var imageReceiver = new ImageReceiver();
            imageReceiver.Start();

            Console.WriteLine("WebSocket server and ImageReceiver started. Press any key to exit...");
            Console.ReadKey();

            
            serverApp.Stop();
            imageReceiver.Stop();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }                   
    }
}
