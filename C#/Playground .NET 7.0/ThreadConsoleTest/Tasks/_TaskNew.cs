namespace ThreadConsoleTest.Tasks
{
    public class _TaskNew
    {
        public static void Start()
        {
            ConsoleHelper.PAD = 10;
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            DoSync();
            DoAsync();
            DoTitle();
            DoSync();
            ConsoleHelper.WriteLine("==========");
        }

        private static void DoSync()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            ConsoleHelper.WriteLine("==========");
        }
        private static async void DoAsync()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Task t1 = new Task(Do1Async);
            t1.Start();
            Task t2 = new Task(async () => await Do2Async());
            t2.Start();
            Task<string> t3 = new Task<string>(() => Do3Async().Result); // BLOCKING
            t3.Start();
            _ = t3.ContinueWith(x =>
            {
                ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                ConsoleHelper.WriteLine("T3=" + t3.Result);
            });

            Task t4 = new Task(async () => Do4Async("444"));
            t4.Start();
            Task t5 = new Task(async () => await Do5Async("555"));
            t5.Start();
            Task<string> t6 = new Task<string>(() => Do6Async("666").Result); // BLOCKING
            t6.Start();
            _ = t6.ContinueWith(x =>
            {
                ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                ConsoleHelper.WriteLine("T6=" + t6.Result);
            });
            ConsoleHelper.WriteLine("==========");

            var tasks = new Task[] { t1, t2, t3, t4, t5, t6 };
            ConsoleHelper.WriteLine("When All");
            await Task.WhenAll(tasks);
            ConsoleHelper.WriteLine("All");
            ConsoleHelper.WriteLine("Do not work with new Task() and some Tasks are BLOCKING");
            ConsoleHelper.WriteLine("==========");
        }
        private static async void Do1Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 1)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(160);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("AAA");
        }
        private static async Task Do2Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i++)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(100);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("BBB");
        }
        private static async Task<string> Do3Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 1)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(60);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("CCC");
            ConsoleHelper.WriteLine("BLOCKING");
            return "CCC";
        }
        private static async void Do4Async(string str)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine(str);
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 2)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(110);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("DDD");
        }
        private static async Task Do5Async(string str)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine(str);
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 2)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(130);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("EEE");
        }
        private static async Task<string> Do6Async(string str)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine(str);
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 2)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(130);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("FFF");
            ConsoleHelper.WriteLine("BLOCKING");
            return "FFF";
        }

        internal static void DoTitle()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int i = 0;
            while (i < 350000)
            {
                Console.Title = i.ToString();
                i++;
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine(i.ToString());
        }
    }
}