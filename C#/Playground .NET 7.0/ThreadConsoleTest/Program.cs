using ThreadConsoleTest.Parallels;
using ThreadConsoleTest.Tasks;
using ThreadConsoleTest.Threads;

namespace ThreadConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Parallels
            //ParallelforImage.Start();

            // Synchronization
            //Lock.Start();
            //MutexLock.Start();
            //SemaphoreSlimLock.Start();

            // Tasks
            //_TaskRunForComputation.Start();
            //_TaskNew.Start();
            //_TaskDeclare.Start();
            _TaskAwaitDeclare.Start();
            //_Task.Start();
            //BreakfastAsync.Cook(args);
            //BreakfastSync.Cook(args);

            //FunctionAsAsyncSample.Start();
            //await TAPSample.Start();
            //TaskContinueWith1.Start();
            //TaskContinueWith2.Start();

            // Threads
            //_ThreadInlineAction.Start();
            //ThreadAFunction1.Start();
            //ThreadAFunction2.Start();
            //ThreadSendDataCallback.Start();

            //DoTitle();
        }

        internal static void DoTitle()
        {
            ConsoleHelper.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int i = 0;
            while (i < 1000000)
            {
                Console.Title = i.ToString();
                i++;
            }
            ConsoleHelper.WriteLine("done");
        }
    }
}