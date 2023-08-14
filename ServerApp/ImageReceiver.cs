namespace Server
{
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
}
