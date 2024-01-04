using System.Net;
using System.Text.Json;

namespace ThreadConsoleTest
{
    public class FunctionAsAsyncSample
    {
        public void FunctionAsAsync()
        {
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");

            DoCall();
            Console.WriteLine("Work done");
        }

        public static async void DoCall()
        {
            await DoFileWorkAsync();
        }

        public static async Task DoFileWorkAsync()
        {
            Console.WriteLine($"File access thread id: {Thread.CurrentThread.ManagedThreadId}");

            string filePath = "matt.json";
            foreach (String s in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                if (s.Contains(".json"))
                {
                    var employeeJson = await File.ReadAllTextAsync(s);
                    await Console.Out.WriteLineAsync(employeeJson);
                }
            }

            await Console.Out.WriteLineAsync("Read finished");
        }

        public void SyncTest()
        {
            Console.WriteLine("DownloadBigFile s");
            DownloadBigFile("https://link.testfile.org/zwj7WO");
            Console.WriteLine("DownloadBigFile d");
        }
        public void DownloadBigFile(string url)
        {
            Console.WriteLine("Downloading..");
            var webClient = new WebClient();
            var b = webClient.DownloadData(url);
            Console.WriteLine($"Downloaded {b.Length}");
        }

        public async void AsyncTest()
        {
            Console.WriteLine("DownloadBigFileAsync s");
            await DownloadBigFileAsync("https://link.testfile.org/zwj7WO");
            Console.WriteLine("DownloadBigFileAsync d");
        }
        public async Task DownloadBigFileAsync(string url)
        {
            Console.WriteLine("Downloading..");
            var webClient = new WebClient();
            var b = await webClient.DownloadDataTaskAsync(url);
            Console.WriteLine($"Downloaded {b.Length}");
        }
    }
}