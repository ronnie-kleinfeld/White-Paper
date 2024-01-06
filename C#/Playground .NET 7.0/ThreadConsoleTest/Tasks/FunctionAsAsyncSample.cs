using System.Net;

namespace ThreadConsoleTest.Tasks
{
    public class FunctionAsAsyncSample
    {
        public static void Start()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("Begin");

            DoCall();

            ConsoleHelper.WriteLine("Finished");
        }

        public static void DoCall()
        {
            ConsoleHelper.WriteLine("1");
            DoFileAsync();
            ConsoleHelper.WriteLine("2");
            DLBigFile("https://link.testfile.org/aYr11v");
            ConsoleHelper.WriteLine("3");
            DLBigFileAsync1("https://link.testfile.org/5RptC7");
            ConsoleHelper.WriteLine("4");
            DLBigFileAsync2("https://link.testfile.org/5RptC7");
            ConsoleHelper.WriteLine("5");
            DLBigFile("https://link.testfile.org/zwj7WO");
            ConsoleHelper.WriteLine("6");
        }

        public static async Task DoFileAsync()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            string filePath = "matt.json";
            foreach (string s in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                if (s.Contains(".json"))
                {
                    var employeeJson = await File.ReadAllTextAsync(s);
                    ConsoleHelper.WriteLine("Json=" + employeeJson.Length.ToString());
                }
            }

            ConsoleHelper.WriteLine("Read finished");
        }

        public static void DLBigFile(string url)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("1");
            var webClient = new WebClient();
            ConsoleHelper.WriteLine("2");
            var b = webClient.DownloadData(url);
            ConsoleHelper.WriteLine($"3 {b.Length}");
        }

        public static async Task DLBigFileAsync1(string url)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("1");
            var webClient = new WebClient();
            ConsoleHelper.WriteLine("2");
            var b = await webClient.DownloadDataTaskAsync(url);
            ConsoleHelper.WriteLine("3");
            ConsoleHelper.WriteLine($"4 {b.Length}");
        }
        public static async Task DLBigFileAsync2(string url)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("1");
            var webClient = new WebClient();
            ConsoleHelper.WriteLine("2");
            var b = await webClient.DownloadDataTaskAsync(url);
            ConsoleHelper.WriteLine("3");
            ConsoleHelper.WriteLine($"4 {b.Length}");
        }
    }
}