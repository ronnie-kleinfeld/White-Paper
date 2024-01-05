namespace ThreadConsoleTest.Tasks
{
    internal class TaskChaining
    {
        public static void Start()
        {
            ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Task<string> antecedent = Task.Run(() =>
            {
                ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Task.Delay(2000);
                return DateTime.Today.ToShortDateString();
            });
            Task<string> continuation = antecedent.ContinueWith(x =>
            {
                ConsoleWriterHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Task.Delay(2000);
                return "Today is " + antecedent.Result;
            });
            ConsoleWriterHelper.WriteLine("This will display before the result");
            ConsoleWriterHelper.WriteLine(continuation.Result);

            ConsoleWriterHelper.WriteFinish();
            Console.ReadKey();
        }
    }
}