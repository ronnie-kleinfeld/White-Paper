namespace ConsoleTest
{
    public class IProgressFromDelayedFunction
    {
        public static void Start()
        {
            ConsoleHelper.PAD = 30;

            ConsoleHelper.WriteLine("Start sample");
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            string[] stages = { "S0", "S1", "S2", "S3", "S4", "S5" };
            IProgress<string> progress = new Progress<string>(stage => { ConsoleHelper.WriteLine("IProgress=" + stage); });
            OnProgress(stages, progress);

            Console.ReadLine();
        }

        public static async void OnProgress(string[] stages, IProgress<string> progress)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            foreach (var stage in stages)
            {
                ConsoleHelper.WriteLine($"{stage} started");
                progress.Report($"{stage} started");

                await Task.Delay(1000);

                progress.Report($"{stage} finished");
                ConsoleHelper.WriteLine($"{stage} finished");
            }
        }
    }
}