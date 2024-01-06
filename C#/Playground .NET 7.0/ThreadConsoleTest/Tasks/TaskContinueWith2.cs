namespace ThreadConsoleTest.Tasks
{
    internal class TaskContinueWith2
    {
        public static void Start()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Task<string> antecedent = Task.Run(() =>
            {
                ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Task.Delay(2000);
                return DateTime.Today.ToShortDateString();
            });
            Task<string> continuation = antecedent.ContinueWith(x =>
            {
                ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Task.Delay(2000);
                return "Today is " + antecedent.Result;
            });
            ConsoleHelper.WriteLine("This will display before the result");
            ConsoleHelper.WriteLine(continuation.Result);

            Console.ReadKey();
        }
    }
}