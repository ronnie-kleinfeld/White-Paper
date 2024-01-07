namespace ThreadConsoleTest.Tasks
{
    public class _Task
    {
        public static async Task Start()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine(DoWork0("000"));
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

            //string result = await DoWork2Async("456");
            //ConsoleHelper.WriteLine(result);

            //Task task = DoWork1Async();
            //await task;

            ConsoleHelper.WriteLine("Counting");
            ConsoleHelper.DoTitle();
        }

        private static string DoWork0(string str)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(800);
            ConsoleHelper.WriteLine("Warming pan...");
            Thread.Sleep(1000);
            ConsoleHelper.WriteLine($"cooking steak ...");

            return str + "apple";
        }
        private static async Task<string> DoWork2Async(string str)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(200);
            ConsoleHelper.WriteLine("Warming pan...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine($"cooking {str} eggs ...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine("eggs ready");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine("eggs on plate");

            return str + "-egg";
        }
        private static async Task<string> DoWork3Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(600);
            ConsoleHelper.WriteLine("Warming pan...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine($"cooking steak ...");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine("steaks ready");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine("steaks on plate");

            return "-steak";
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