using ThreadConsoleTest.Parallels;
using ThreadConsoleTest.Tasks;
using ThreadConsoleTest.Threads;

namespace ThreadConsoleTest
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            // Parallels
            //ParallelforImage.Start();

            // Synchronization
            //Lock.Start();
            //MutexLock.Start();
            //SemaphoreSlimLock.Start();

            // Tasks
            //await BreakfastAsync.Cook(args);
            //BreakfastSync.Cook(args);

            //FunctionAsAsyncSample.Start();
            //await TAPSample.Start();
            //TaskChaining.Start();

            // Threads
            //_ThreadInlineAction.Start();
            //ThreadAFunction1.Start();
            //ThreadAFunction2.Start();
            //ThreadSendDataCallback.Start();
        }
    }
}