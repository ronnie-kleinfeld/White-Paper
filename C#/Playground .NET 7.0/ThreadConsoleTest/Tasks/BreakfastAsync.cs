namespace ThreadConsoleTest.Tasks
{
    public class BreakfastAsync
    {
        internal static async Task Cook(string[] args)
        {
            Coffee cup = PourCoffee();
            ConsoleWriterHelper.WriteLine("coffee ready");

            ConsoleWriterHelper.WriteLine("making toast");
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(3);

            ConsoleWriterHelper.WriteLine("making eggs");
            Task<Egg> eggsTask = FryEggsAsync(5);

            ConsoleWriterHelper.WriteLine("making bacon");
            Task<Bacon> baconTask = FryBaconAsync(6);

            //await TasksSequantialy(toastTask, eggsTask, baconTask);
            //await TasksAwait(toastTask, eggsTask, baconTask);
            //await TasksWhileWhenAny(toastTask, eggsTask, baconTask);

            await TasksRun(toastTask, eggsTask, baconTask);

            Juice oj = PourOJ();
            ConsoleWriterHelper.WriteLine("oj ready");

            ConsoleWriterHelper.WriteLine("Breakfast ready!");

            ConsoleWriterHelper.WriteFinish();
        }

        private static async Task TasksSequantialy(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            Egg eggs = await eggsTask;
            ConsoleWriterHelper.WriteLine("eggs ready");

            Bacon bacon = await baconTask;
            ConsoleWriterHelper.WriteLine("bacon ready");

            Toast toast = await toastTask;
            ConsoleWriterHelper.WriteLine("toast ready");
        }
        private static async Task TasksAwait(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            var tasks = new Task[] { eggsTask, baconTask, toastTask };

            //await Task.WhenAll(tasks);                        // wait until ALL tasks finished, current thread is RUNNING
            //await Task.WhenAny(tasks);                        // wait until ONE tasks finished, current thread is RUNNING
            //Task.WaitAll(eggsTask, baconTask, toastTask);     // wait until ALL tasks finished, current thread is BLOCKED
            //Task.WaitAny(eggsTask, baconTask, toastTask);     // wait until ONE tasks finished, current thread is BLOCKED
            ConsoleWriterHelper.WriteLine("Eggs ready");
            ConsoleWriterHelper.WriteLine("Bacon ready");
            ConsoleWriterHelper.WriteLine("Toast ready");
        }
        private static async Task TasksWhileWhenAny(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            ConsoleWriterHelper.WriteLine("tasks starting");
            var tasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (tasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(tasks);
                if (finishedTask == eggsTask)
                {
                    ConsoleWriterHelper.WriteLine("Eggs ready");
                }
                else if (finishedTask == baconTask)
                {
                    ConsoleWriterHelper.WriteLine("Bacon ready");
                }
                else if (finishedTask == toastTask)
                {
                    ConsoleWriterHelper.WriteLine("Toast ready");
                }
                await finishedTask;
                ConsoleWriterHelper.WriteLine($"{finishedTask.Id} removed");
                tasks.Remove(finishedTask);
            }
            ConsoleWriterHelper.WriteLine("tasks finished");
        }

        private static async Task TasksRun(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            var tasks = new Task[] { eggsTask, baconTask, toastTask };

            await Task.Run(() => toastTask);
            await Task.Run(() => eggsTask);
            await Task.Run(() => baconTask);

            ConsoleWriterHelper.WriteLine("Eggs ready");
            ConsoleWriterHelper.WriteLine("Bacon ready");
            ConsoleWriterHelper.WriteLine("Toast ready");
        }

        private static Juice PourOJ()
        {
            ConsoleWriterHelper.WriteLine("Pouring OJ");
            return new Juice();
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }
        private static void ApplyJam(Toast toast) =>
            ConsoleWriterHelper.WriteLine("jam on toast");

        private static void ApplyButter(Toast toast) =>
            ConsoleWriterHelper.WriteLine("butter on toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            ConsoleWriterHelper.WriteLine($"Do {slices} toast");
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.WriteLine("bread in toaster");
            }
            ConsoleWriterHelper.WriteLine("toasting...");
            await Task.Delay(8000);
            //throw new InvalidOperationException("The toaster is on fire");

            ConsoleWriterHelper.WriteLine("Remove toast");
            await Task.Delay(1000);
            ConsoleWriterHelper.WriteLine("bread toasted");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            ConsoleWriterHelper.WriteLine($"Do {slices} bacon");
            ConsoleWriterHelper.WriteLine("Warming pan...");
            await Task.Delay(5000);
            ConsoleWriterHelper.WriteLine($"{slices} bacon in pan");
            ConsoleWriterHelper.WriteLine("first bacon...");
            await Task.Delay(6000);
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.WriteLine("flipping bacon");
            }
            ConsoleWriterHelper.WriteLine("second bacon...");
            await Task.Delay(6000);
            ConsoleWriterHelper.WriteLine("bacon ready");
            await Task.Delay(1000);
            ConsoleWriterHelper.WriteLine("bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            ConsoleWriterHelper.WriteLine($"Do {howMany} egg");
            ConsoleWriterHelper.WriteLine("Warming pan...");
            await Task.Delay(4000);
            ConsoleWriterHelper.WriteLine($"{howMany} eggs");
            ConsoleWriterHelper.WriteLine("cooking eggs ...");
            await Task.Delay(16000);
            ConsoleWriterHelper.WriteLine("eggs ready");
            await Task.Delay(1000);
            ConsoleWriterHelper.WriteLine("eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            ConsoleWriterHelper.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}