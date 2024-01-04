namespace ThreadConsoleTest
{
    public class TAPSample
    {
        public static async Task Samples()
        {
            //await StartATask();
            await AwaitAndResult();
        }
        public static async Task StartATask()
        {
            Console.WriteLine($"Start StartATask {Thread.CurrentThread.ManagedThreadId}");

            // blocking, call on same thread
            //ProcessData();            

            // not Blocking, call on other thread
            //Task.Run(ProcessData);

            // not blocking, call on other thread
            //Task.Run(() =>            
            //{
            //    Console.WriteLine($"Start Lambda {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(3000);
            //    Console.WriteLine("Finish Lambda");
            //});

            // not blocking, call on other thread
            //var task = new Task(ProcessData);
            //task.Start();

            Console.WriteLine("Finished StartATask");
            Console.ReadLine();
        }

        public static async Task AwaitAndResult()
        {
            Console.WriteLine($"Start AwaitAndResult {Thread.CurrentThread.ManagedThreadId}");

            Task<string> task = Task.Run<string>(ProcessData1);

            // blocking
            //task.Wait();

            // blocking
            //var str = task.Result;
            //Console.WriteLine(str);

            Console.WriteLine("Finished AwaitAndResult");
            Console.ReadLine();
        }

        public static Task<string> ProcessData1()
        {
            Console.WriteLine($"Start Processing1 {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(3000);
            Console.WriteLine("Finish Processing1");
            return Task.FromResult("014290985");
        }

        public static Task<string> ProcessData2()
        {
            Console.WriteLine($"Start Processing2 {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(3000);
            Console.WriteLine("Finish Processing2");
            return Task.FromResult("014290985");
        }
    }
}