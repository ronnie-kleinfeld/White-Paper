namespace ThreadConsoleTest.Tasks
{
    public class TAPSample
    {
        public static async Task Samples()
        {
            //await StartATask();
            //await WaitAndResult();
            //await Continuation();
            //await Await();
            await AggregateException();
        }
        public static async Task StartATask()
        {
            Console.WriteLine($"Start StartATask {Thread.CurrentThread.ManagedThreadId}");

            // blocking, call on same thread
            //ProcessData();            

            // not Blocking, call on other thread
            //Task.Run(ProcessData);

            // not blocking, call on other thread
            //Task.Run(() =>            
            //{
            //    Console.WriteLine($"Start Lambda {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(3000);
            //    Console.WriteLine("Finish Lambda");
            //});

            // not blocking, call on other thread
            //var task = new Task(ProcessData);
            //task.Start();

            Console.WriteLine("Finished StartATask");
            Console.ReadLine();
        }

        public static async Task WaitAndResult()
        {
            Console.WriteLine($"Start AwaitAndResult {Thread.CurrentThread.ManagedThreadId}");

            Task<string> task = Task.Run(ProcessData);

            // blocking
            //task.Wait();

            // blocking
            //var str = task.Result;
            //Console.WriteLine(str);

            Console.WriteLine("Finished AwaitAndResult");
            Console.ReadLine();
        }

        public static async Task Continuation()
        {
            Console.WriteLine($"Start Continuation {Thread.CurrentThread.ManagedThreadId}");

            // not blocking, use ContinueWith to nest the a 2nd task/thread and there wait for the result
            Task<string> task = Task.Run(ProcessData);
            var task2 = task.ContinueWith(completedTask =>
            {
                var str = completedTask.Result;
                Console.WriteLine(str);
            });

            Console.WriteLine("Finished Continuation");
            Console.ReadLine();
        }

        public static async Task Await()
        {
            Console.WriteLine($"Start Await {Thread.CurrentThread.ManagedThreadId}");

            // not blocking, call on same thread
            Task t = DownloadDataAsync();

            Console.WriteLine("Finished Await");
            Console.ReadLine();
        }
        public static async Task AggregateException()
        {
            Console.WriteLine($"Start Await {Thread.CurrentThread.ManagedThreadId}");

            // not blocking, call on same thread
            Task t = ExceptionAsync();

            Console.WriteLine("Finished Await");
            Console.ReadLine();
        }

        public static Task<string> ProcessData()
        {
            Console.WriteLine($"Start Processing1 {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(3000);
            Console.WriteLine("Finish Processing1");
            return Task.FromResult("014290985");
        }
        public static async Task<string> DownloadDataAsync()
        {
            Console.WriteLine($"Start ProcessDataAsync {Thread.CurrentThread.ManagedThreadId}");
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://www.linkedin.com/learning/asynchronous-programming-in-c-sharp/awaiting-a-task?autoSkip=true&resume=false&u=0");
            Console.WriteLine(response.StatusCode);
            Console.WriteLine("Finish ProcessDataAsync");
            return response.StatusCode.ToString();
        }
        public static async Task ExceptionAsync()
        {
            Console.WriteLine($"Start ExceptionAsync {Thread.CurrentThread.ManagedThreadId}");
            try
            {
                var httpClient = new HttpClient();
                var task = httpClient.GetAsync("http://expired.badssl.com");
                var response = task.Result;
                Console.WriteLine(response.StatusCode);
            }
            catch (AggregateException aex)
            {
                Console.WriteLine(aex.GetType());
                foreach (Exception ex in aex.InnerExceptions)
                {
                    Console.WriteLine(ex.GetType());
                }
            }
            Console.WriteLine("Finish ExceptionAsync");
        }
    }
}