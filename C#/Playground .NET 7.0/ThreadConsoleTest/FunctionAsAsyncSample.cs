using System.Net;

namespace ThreadConsoleTest
{
    public class FunctionAsAsyncSample
    {
        public static void Usage()
        {
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.Write("Begin");

            DoCall();

            ConsoleWriterHelper.Write("Finished");
            ConsoleWriterHelper.WriteFinish();
        }

        public static void DoCall()
        {
            ConsoleWriterHelper.Write("1");
            DoFileAsync();
            ConsoleWriterHelper.Write("2");
            DLBigFile("https://link.testfile.org/aYr11v");
            ConsoleWriterHelper.Write("3");
            DLBigFileAsync1("https://link.testfile.org/5RptC7");
            ConsoleWriterHelper.Write("4");
            DLBigFileAsync2("https://link.testfile.org/5RptC7");
            ConsoleWriterHelper.Write("5");
            DLBigFile("https://link.testfile.org/zwj7WO");
            ConsoleWriterHelper.Write("6");
        }

        public static async Task DoFileAsync()
        {
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");

            string filePath = "matt.json";
            foreach (String s in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                if (s.Contains(".json"))
                {
                    var employeeJson = await File.ReadAllTextAsync(s);
                    ConsoleWriterHelper.Write("Json=" + employeeJson.Length.ToString());
                }
            }

            ConsoleWriterHelper.Write("Read finished");
        }

        public static void DLBigFile(string url)
        {
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.Write("1");
            var webClient = new WebClient();
            ConsoleWriterHelper.Write("2");
            var b = webClient.DownloadData(url);
            ConsoleWriterHelper.Write($"3 {b.Length}");
        }

        public static async Task DLBigFileAsync1(string url)
        {
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.Write("1");
            var webClient = new WebClient();
            ConsoleWriterHelper.Write("2");
            var b = await webClient.DownloadDataTaskAsync(url);
            ConsoleWriterHelper.Write("3");
            ConsoleWriterHelper.Write($"4 {b.Length}");
        }
        public static async Task DLBigFileAsync2(string url)
        {
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");
            ConsoleWriterHelper.Write("1");
            var webClient = new WebClient();
            ConsoleWriterHelper.Write("2");
            var b = await webClient.DownloadDataTaskAsync(url);
            ConsoleWriterHelper.Write("3");
            ConsoleWriterHelper.Write($"4 {b.Length}");
        }
    }
}