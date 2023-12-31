﻿namespace ThreadConsoleTest.Tasks
{
    public class _TaskRunForComputation
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
            Task t1 = Task.Run(Do1Async);
            Task t2 = Task.Run(Do2Async);
            Task<string> t3 = Task.Run(Do3Async);
            _ = t3.ContinueWith(x =>
            {
                ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                ConsoleHelper.WriteLine(t3.Result);
            });
            Task t4 = Task.Run(() => Do4Async("444"));
            Task t5 = Task.Run(() => Do5Async("555"));
            Task<string> t6 = Task.Run(() => Do6Async("666"));
            _ = t6.ContinueWith(x =>
            {
                ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                ConsoleHelper.WriteLine(t6.Result);
            });
            ConsoleHelper.WriteLine("==========");

            var tasks = new Task[] { t1, t2, t3, t4, t5, t6 };

            ConsoleHelper.WriteLine("When All");
            await Task.WhenAll(tasks);
            ConsoleHelper.WriteLine("All");
            ConsoleHelper.WriteLine("==========");
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
                await Task.Delay(80);
            }
            ConsoleHelper.WriteLine("==========");
            ConsoleHelper.WriteLine("CCC");
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