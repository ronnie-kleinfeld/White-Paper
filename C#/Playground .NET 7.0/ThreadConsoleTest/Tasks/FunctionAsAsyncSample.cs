using System.Net;

namespace ThreadConsoleTest.Tasks
{
    public class FunctionAsAsyncSample
    {
        public static void Usage()
        {
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.WriteLine("Begin");

            DoCall();

            ConsoleWriterHelper.WriteLine("Finished");
            ConsoleWriterHelper.WriteFinish();
        }

        public static void DoCall()
        {
            ConsoleWriterHelper.WriteLine("1");
            DoFileAsync();
            ConsoleWriterHelper.WriteLine("2");
            DLBigFile("https://link.testfile.org/aYr11v");
            ConsoleWriterHelper.WriteLine("3");
            DLBigFileAsync1("https://link.testfile.org/5RptC7");
            ConsoleWriterHelper.WriteLine("4");
            DLBigFileAsync2("https://link.testfile.org/5RptC7");
            ConsoleWriterHelper.WriteLine("5");
            DLBigFile("https://link.testfile.org/zwj7WO");
            ConsoleWriterHelper.WriteLine("6");
        }

        public static async Task DoFileAsync()
        {
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");

            string filePath = "matt.json";
            foreach (string s in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                if (s.Contains(".json"))
                {
                    var employeeJson = await File.ReadAllTextAsync(s);
                    ConsoleWriterHelper.WriteLine("Json=" + employeeJson.Length.ToString());
                }
            }

            ConsoleWriterHelper.WriteLine("Read finished");
        }

        public static void DLBigFile(string url)
        {
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.WriteLine("1");
            var webClient = new WebClient();
            ConsoleWriterHelper.WriteLine("2");
            var b = webClient.DownloadData(url);
            ConsoleWriterHelper.WriteLine($"3 {b.Length}");
        }

        public static async Task DLBigFileAsync1(string url)
        {
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.WriteLine("1");
            var webClient = new WebClient();
            ConsoleWriterHelper.WriteLine("2");
            var b = await webClient.DownloadDataTaskAsync(url);
            ConsoleWriterHelper.WriteLine("3");
            ConsoleWriterHelper.WriteLine($"4 {b.Length}");
        }
        public static async Task DLBigFileAsync2(string url)
        {
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.WriteLine("1");
            var webClient = new WebClient();
            ConsoleWriterHelper.WriteLine("2");
            var b = await webClient.DownloadDataTaskAsync(url);
            ConsoleWriterHelper.WriteLine("3");
            ConsoleWriterHelper.WriteLine($"4 {b.Length}");
        }
    }
}