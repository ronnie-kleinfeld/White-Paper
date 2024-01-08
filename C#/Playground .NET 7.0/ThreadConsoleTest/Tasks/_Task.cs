namespace ThreadConsoleTest.Tasks
{
    public class _Task
    {
        public static void Start()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            DoWork1Async();

            Task<string> work2Task = DoWork2Async("123");
            _ = work2Task.ContinueWith(x =>
            {
                ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                ConsoleHelper.WriteLine(work2Task.Result);
            });

            Task<string> work3Task = Task.Run<string>(DoWork3Async);
            _ = work3Task.ContinueWith(x =>
            {
                ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                ConsoleHelper.WriteLine(work3Task.Result);
            });

            Task work4Task = new Task(DoWork4Async);
            work4Task.Start();

            //string result = await DoWork2Async("456");
            //ConsoleHelper.WriteLine(result);

            //Task task = DoWork1Async();
            //await task;

            ConsoleHelper.WriteLine("Counting");
            ConsoleHelper.WriteLine("Done");
            Console.ReadKey();
        }

        private static async Task<string> DoWork2Async(string str)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(200);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("Warming pan...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine($"cooking {str} eggs ...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("eggs ready");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("eggs on plate");

            return str + "-egg";
        }
        private static async Task<string> DoWork3Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(600);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("Warming pan...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine($"cooking steak ...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("steaks ready");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("steaks on plate");

            return "-steak";
        }
        private static async void DoWork4Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(600);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("Warming pan...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine($"cooking homus ...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("homus ready");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("homus on plate");
        }

        private static async void DoWork1Async()
        {
            Task t;

            int slices = 4;
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(400);
            ConsoleHelper.WriteLine($"Do {slices} bacon");
            ConsoleHelper.WriteLine("Warming pan...");
            t = Task.Delay(2000);
            await t;
            ConsoleHelper.WriteLine($"{slices} bacon in pan");
            ConsoleHelper.WriteLine("first bacon...");
            t = Task.Delay(2000);
            await t;
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleHelper.WriteLine("flipping bacon");
            }
            ConsoleHelper.WriteLine("second bacon...");
            t = Task.Delay(2000);
            await t;
            ConsoleHelper.WriteLine("bacon ready");
            t = Task.Delay(2000);
            await t;
            ConsoleHelper.WriteLine("bacon on plate");
        }
    }
}