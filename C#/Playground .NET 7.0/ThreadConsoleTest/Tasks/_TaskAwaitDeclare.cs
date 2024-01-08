namespace ThreadConsoleTest.Tasks
{
    public class _TaskAwaitDeclare
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
            Do1Async();
            await Do2Async();
            string s3 = await Do3Async();
            ConsoleHelper.WriteLine(s3);
            Do4Async("444");
            await Do5Async("555");
            string s6 = await Do6Async("666");
            ConsoleHelper.WriteLine(s6);
            ConsoleHelper.WriteLine("==========");

            ConsoleHelper.WriteLine("No wait all, await on a single task alone");
            ConsoleHelper.WriteLine("==========");
        }
        private static async void Do1Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("Async");
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 2)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(130);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("AAA");
        }
        private static async Task Do2Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("await");
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
            ConsoleHelper.WriteLine("await");
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 1)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(80);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("CCC");
            return "CCC";
        }
        private static async void Do4Async(string str)
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            ConsoleHelper.WriteLine("Async");
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
            ConsoleHelper.WriteLine("await");
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
            ConsoleHelper.WriteLine("await");
            ConsoleHelper.WriteLine(str);
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 2)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(130);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("FFF");
            return "FFF";
        }

        internal static void DoTitle()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int i = 0;
            while (i < 650000)
            {
                Console.Title = i.ToString();
                i++;
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine(i.ToString());
        }
    }
}