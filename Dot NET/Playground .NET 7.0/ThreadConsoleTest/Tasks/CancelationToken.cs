namespace ThreadConsoleTest.Tasks
{
    public class CancelationToken
    {
        public static void Start()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(4000);
                tokenSource.Cancel();
            });
            DownloadAsync(new Uri("https://jsonplaceholder.typicode.com/posts"), token).Wait();
        }

        public static async Task DownloadAsync(Uri uri,
            CancellationToken token)
        {
            while (true)
            {
                token.ThrowIfCancellationRequested();
                try
                {
                    HttpResponseMessage result = await GetAsync(uri);//3 secn
                    Console.WriteLine("Result is {0}", result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static Task<HttpResponseMessage> GetAsync(Uri uri)
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync(uri);
            return result;
        }
    }
}