namespace ThreadConsoleTest.Tasks
{
    public class ProgressOfAsyncProcess
    {
        public static async void Start()
        {
            ConsoleHelper.WriteLine("Start sample");
            ConsoleHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");

            string[] departments = { "Engineering", "Sales", "Marketing", "Support" };
            IProgress<string> progress = new Progress<string>(d => { ConsoleHelper.WriteLine(d); });
            var dataTask = ProcessData(departments, progress);

            Console.ReadLine();

            await dataTask;
        }

        public static async Task ProcessData(string[] departments, IProgress<string> progress)
        {
            ConsoleHelper.WriteLine("ProcessData1");
            ConsoleHelper.WriteLine($"tid={Thread.CurrentThread.ManagedThreadId}");
            foreach (var department in departments)
            {
                progress.Report($"{department} started");
                ConsoleHelper.WriteLine($"{department} 1");

                await Task.Delay(1000);

                ConsoleHelper.WriteLine($"{department} 2");
                progress.Report($"{department} finished");
            }
            ConsoleHelper.WriteLine("ProcessData2");
        }
    }
}