namespace ThreadConsoleTest.Tasks
{
    public class _Task2
    {
        public static void Start()
        {
            ConsoleHelper.PAD = 10;
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            DoSync();
            DoAsync();
            DoTitle();
            DoSync();
            ConsoleHelper.WriteLine("done");
        }

        private static void DoSync()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            ConsoleHelper.WriteLine("done");
        }
        private static async void DoAsync()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Task.Run(Do1Async);
            Task.Run(Do2Async);
            Task.Run(Do3Async);
            Task.Run(() => Do4Async("abc"));
            Task.Run(() => Do5Async("abc"));
            Task.Run(() => Do6Async("abc"));
            ConsoleHelper.WriteLine("done");
        }
        private static async void Do1Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 2)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(130);
            }
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
        }
        private static async Task<string> Do3Async()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int y = Console.GetCursorPosition().Top;
            for (int i = 0; i < 100; i += 1)
            {
                ConsoleHelper.WriteProgress(y, i, 100);
                await Task.Delay(80);
            }
            return "123";
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
            return "123";
        }

        internal static void DoTitle()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int i = 0;
            while (i < 200000)
            {
                Console.Title = i.ToString();
                i++;
            }
            ConsoleHelper.WriteLine("done");
        }
    }
}