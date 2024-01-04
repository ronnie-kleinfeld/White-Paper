namespace ThreadConsoleTest
{
    public class TAPSample
    {
        public static async Task Process()
        {
            Console.WriteLine($"Start Program {Thread.CurrentThread.ManagedThreadId}");
            //ProcessData();            // blocking, call on same thread
            //Task.Run(ProcessData);    // not Blocking, call on other thread
            //Task.Run(() =>            // not blocking, call on other thread
            {
                Console.WriteLine($"Start Lambda {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(3000);
                Console.WriteLine("Finish Lambda");
            });
            Console.WriteLine("Finished Program");
            Console.ReadLine();
        }

        public static void ProcessData()
        {
            Console.WriteLine($"Start Processing {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(3000);
            Console.WriteLine("Finish Processing");
        }
    }
}