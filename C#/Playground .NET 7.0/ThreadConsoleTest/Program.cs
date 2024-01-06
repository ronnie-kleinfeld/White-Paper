using ThreadConsoleTest.Parallels;
using ThreadConsoleTest.Tasks;
using ThreadConsoleTest.Threads;

namespace ThreadConsoleTest
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            ThreadAFunction.Start();
            //ThreadAFunctionSample.Start();
            //ThreadSendDataCallback.Start();

            //FunctionAsAsyncSample.Start();

            //BreakfastSync.Cook(args);
            //await BreakfastAsync.Cook(args);
            //await TAPSample.Start();
            //ProgressOfAsyncProcess.Start();
            //Lock.Start();
            //TaskChaining.Start();
            //MutexLock.Start();
            //SemaphoreSlimLock.Start();
            //ParallelforImage.Start();
        }
    }
}