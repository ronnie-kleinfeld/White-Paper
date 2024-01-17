namespace PlaygroundTest.Core.Event
{
    [TestClass]
    public class IProgressTest
    {
        [TestMethod]
        public void Start()
        {
            Console.WriteLine("Start sample");

            string[] stages = { "S0", "S1", "S2", "S3", "S4", "S5" };
            IProgress<string> progress = new Progress<string>(stage => { Console.WriteLine("IProgress=" + stage); });
            OnProgress(stages, progress);

        }

        public static async void OnProgress(string[] stages, IProgress<string> progress)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            foreach (var stage in stages)
            {
                Console.WriteLine($"{stage} started");
                progress.Report($"{stage} started");

                await Task.Delay(100);

                progress.Report($"{stage} finished");
                Console.WriteLine($"{stage} finished");
            }
        }
    }
}