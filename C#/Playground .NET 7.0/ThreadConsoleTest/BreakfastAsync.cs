namespace ThreadConsoleTest
{
    public class BreakfastAsync
    {
        internal static async Task Cook(string[] args)
        {
            Coffee cup = PourCoffee();
            ConsoleWriterHelper.Write("coffee ready");

            ConsoleWriterHelper.Write("making toast");
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(3);

            ConsoleWriterHelper.Write("making eggs");
            Task<Egg> eggsTask = FryEggsAsync(5);

            ConsoleWriterHelper.Write("making bacon");
            Task<Bacon> baconTask = FryBaconAsync(6);

            //await TasksSequantialy(toastTask, eggsTask, baconTask);
            //await TasksAwait(toastTask, eggsTask, baconTask);
            await TasksWhileWhenAny(toastTask, eggsTask, baconTask);

            //await TasksRun(toastTask, eggsTask, baconTask);

            Juice oj = PourOJ();
            ConsoleWriterHelper.Write("oj ready");

            ConsoleWriterHelper.Write("Breakfast ready!");

            ConsoleWriterHelper.WriteFinish();
        }

        private static async Task TasksSequantialy(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            Egg eggs = await eggsTask;
            ConsoleWriterHelper.Write("eggs ready");

            Bacon bacon = await baconTask;
            ConsoleWriterHelper.Write("bacon ready");

            Toast toast = await toastTask;
            ConsoleWriterHelper.Write("toast ready");
        }
        private static async Task TasksAwait(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            var tasks = new Task[] { eggsTask, baconTask, toastTask };

            //await Task.WhenAll(tasks);                        // wait until ALL tasks finished, current thread is RUNNING
            //await Task.WhenAny(tasks);                        // wait until ONE tasks finished, current thread is RUNNING
            //Task.WaitAll(eggsTask, baconTask, toastTask);     // wait until ALL tasks finished, current thread is BLOCKED
            //Task.WaitAny(eggsTask, baconTask, toastTask);     // wait until ONE tasks finished, current thread is BLOCKED
            ConsoleWriterHelper.Write("Eggs ready");
            ConsoleWriterHelper.Write("Bacon ready");
            ConsoleWriterHelper.Write("Toast ready");
        }
        private static async Task TasksWhileWhenAny(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            ConsoleWriterHelper.Write("tasks starting");
            var tasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (tasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(tasks);
                if (finishedTask == eggsTask)
                {
                    ConsoleWriterHelper.Write("Eggs ready");
                }
                else if (finishedTask == baconTask)
                {
                    ConsoleWriterHelper.Write("Bacon ready");
                }
                else if (finishedTask == toastTask)
                {
                    ConsoleWriterHelper.Write("Toast ready");
                }
                await finishedTask;
                ConsoleWriterHelper.Write($"{finishedTask.Id} removed");
                tasks.Remove(finishedTask);
            }
            ConsoleWriterHelper.Write("tasks finished");
        }

        private static async Task CallTasksRun(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            var tasks = new Task[] { eggsTask, baconTask, toastTask };

            await Task.Run(() => toastTask);
            await Task.Run(() => eggsTask);
            await Task.Run(() => baconTask);

            ConsoleWriterHelper.Write("Eggs ready");
            ConsoleWriterHelper.Write("Bacon ready");
            ConsoleWriterHelper.Write("Toast ready");
        }

        private static Juice PourOJ()
        {
            ConsoleWriterHelper.Write("Pouring OJ");
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
            ConsoleWriterHelper.Write("jam on toast");

        private static void ApplyButter(Toast toast) =>
            ConsoleWriterHelper.Write("butter on toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            ConsoleWriterHelper.Write($"Do {slices} toast");
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.Write("bread in toaster");
            }
            ConsoleWriterHelper.Write("toasting...");
            await Task.Delay(8000);
            //throw new InvalidOperationException("The toaster is on fire");

            ConsoleWriterHelper.Write("Remove toast");
            await Task.Delay(1000);
            ConsoleWriterHelper.Write("bread toasted");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            ConsoleWriterHelper.Write($"Do {slices} bacon");
            ConsoleWriterHelper.Write("Warming pan...");
            await Task.Delay(5000);
            ConsoleWriterHelper.Write($"{slices} bacon in pan");
            ConsoleWriterHelper.Write("first bacon...");
            await Task.Delay(6000);
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.Write("flipping bacon");
            }
            ConsoleWriterHelper.Write("second bacon...");
            await Task.Delay(6000);
            ConsoleWriterHelper.Write("bacon ready");
            await Task.Delay(1000);
            ConsoleWriterHelper.Write("bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            ConsoleWriterHelper.Write($"Do {howMany} egg");
            ConsoleWriterHelper.Write("Warming pan...");
            await Task.Delay(4000);
            ConsoleWriterHelper.Write($"{howMany} eggs");
            ConsoleWriterHelper.Write("cooking eggs ...");
            await Task.Delay(16000);
            ConsoleWriterHelper.Write("eggs ready");
            await Task.Delay(1000);
            ConsoleWriterHelper.Write("eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            ConsoleWriterHelper.Write("Pouring coffee");
            return new Coffee();
        }
    }
}