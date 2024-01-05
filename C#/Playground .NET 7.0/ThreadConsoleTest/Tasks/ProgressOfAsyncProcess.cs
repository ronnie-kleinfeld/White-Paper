namespace ThreadConsoleTest.Tasks
{
    public class ProgressOfAsyncProcess
    {
        public static async void ProgressSample()
        {
            ConsoleWriterHelper.WriteLine("Start sample");
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");

            string[] departments = { "Engineering", "Sales", "Marketing", "Support" };
            IProgress<string> progress = new Progress<string>(d => { ConsoleWriterHelper.WriteLine(d); });
            var dataTask = ProcessData(departments, progress);

            ConsoleWriterHelper.WriteFinish();
            Console.ReadLine();

            await dataTask;
        }

        public static async Task ProcessData(string[] departments, IProgress<string> progress)
        {
            ConsoleWriterHelper.WriteLine("ProcessData1");
            ConsoleWriterHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");
            foreach (var department in departments)
            {
                progress.Report($"{department} started");
                ConsoleWriterHelper.WriteLine($"{department} 1");

                await Task.Delay(1000);

                ConsoleWriterHelper.WriteLine($"{department} 2");
                progress.Report($"{department} finished");
            }
            ConsoleWriterHelper.WriteLine("ProcessData2");
        }
    }
}