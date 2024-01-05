namespace ThreadConsoleTest
{
    public class ProgressOfAsyncProcess
    {
        public static async void ProgressSample()
        {
            ConsoleWriterHelper.Write("Start sample");
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");

            string[] departments = { "Engineering", "Sales", "Marketing", "Support" };
            IProgress<string> progress = new Progress<string>(d => { ConsoleWriterHelper.Write(d); });
            var dataTask = ProcessData(departments, progress);

            ConsoleWriterHelper.WriteFinish();
            Console.ReadLine();

            await dataTask;
        }

        public static async Task ProcessData(string[] departments, IProgress<string> progress)
        {
            ConsoleWriterHelper.Write("ProcessData1");
            ConsoleWriterHelper.Write($"tid={Thread.CurrentThread.ManagedThreadId}");
            foreach (var department in departments)
            {
                progress.Report($"{department} started");
                ConsoleWriterHelper.Write($"{department} 1");

                await Task.Delay(1000);

                ConsoleWriterHelper.Write($"{department} 2");
                progress.Report($"{department} finished");
            }
            ConsoleWriterHelper.Write("ProcessData2");
        }
    }
}