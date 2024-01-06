namespace ThreadConsoleTest.Tasks
{
    public class BreakfastAsync
    {
        internal static async Task Cook(string[] args)
        {
            Coffee cup = PourCoffee();
            ConsoleHelper.WriteLine("coffee ready");

            ConsoleHelper.WriteLine("making toast");
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(3);

            ConsoleHelper.WriteLine("making eggs");
            Task<Egg> eggsTask = FryEggsAsync(5);

            ConsoleHelper.WriteLine("making bacon");
            Task<Bacon> baconTask = FryBaconAsync(6);

            //await TasksSequantialy(toastTask, eggsTask, baconTask);
            //await TasksAwait(toastTask, eggsTask, baconTask);
            //await TasksWhileWhenAny(toastTask, eggsTask, baconTask);

            await TasksRun(toastTask, eggsTask, baconTask);

            Juice oj = PourOJ();
            ConsoleHelper.WriteLine("oj ready");

            ConsoleHelper.WriteLine("Breakfast ready!");
        }

        private static async Task TasksSequantialy(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            Egg eggs = await eggsTask;
            ConsoleHelper.WriteLine("eggs ready");

            Bacon bacon = await baconTask;
            ConsoleHelper.WriteLine("bacon ready");

            Toast toast = await toastTask;
            ConsoleHelper.WriteLine("toast ready");
        }
        private static async Task TasksAwait(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            var tasks = new Task[] { eggsTask, baconTask, toastTask };

            //await Task.WhenAll(tasks);                        // wait until ALL tasks finished, current thread is RUNNING
            //await Task.WhenAny(tasks);                        // wait until ONE tasks finished, current thread is RUNNING
            //Task.WaitAll(eggsTask, baconTask, toastTask);     // wait until ALL tasks finished, current thread is BLOCKED
            //Task.WaitAny(eggsTask, baconTask, toastTask);     // wait until ONE tasks finished, current thread is BLOCKED
            ConsoleHelper.WriteLine("Eggs ready");
            ConsoleHelper.WriteLine("Bacon ready");
            ConsoleHelper.WriteLine("Toast ready");
        }
        private static async Task TasksWhileWhenAny(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            ConsoleHelper.WriteLine("tasks starting");
            var tasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (tasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(tasks);
                if (finishedTask == eggsTask)
                {
                    ConsoleHelper.WriteLine("Eggs ready");
                }
                else if (finishedTask == baconTask)
                {
                    ConsoleHelper.WriteLine("Bacon ready");
                }
                else if (finishedTask == toastTask)
                {
                    ConsoleHelper.WriteLine("Toast ready");
                }
                await finishedTask;
                ConsoleHelper.WriteLine($"{finishedTask.Id} removed");
                tasks.Remove(finishedTask);
            }
            ConsoleHelper.WriteLine("tasks finished");
        }

        private static async Task TasksRun(Task<Toast> toastTask, Task<Egg> eggsTask, Task<Bacon> baconTask)
        {
            var tasks = new Task[] { eggsTask, baconTask, toastTask };

            await Task.Run(() => toastTask);
            await Task.Run(() => eggsTask);
            await Task.Run(() => baconTask);

            ConsoleHelper.WriteLine("Eggs ready");
            ConsoleHelper.WriteLine("Bacon ready");
            ConsoleHelper.WriteLine("Toast ready");
        }

        private static Juice PourOJ()
        {
            ConsoleHelper.WriteLine("Pouring OJ");
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
            ConsoleHelper.WriteLine("jam on toast");

        private static void ApplyButter(Toast toast) =>
            ConsoleHelper.WriteLine("butter on toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            ConsoleHelper.WriteLine($"Do {slices} toast");
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleHelper.WriteLine("bread in toaster");
            }
            ConsoleHelper.WriteLine("toasting...");
            await Task.Delay(8000);
            //throw new InvalidOperationException("The toaster is on fire");

            ConsoleHelper.WriteLine("Remove toast");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine("bread toasted");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            ConsoleHelper.WriteLine($"Do {slices} bacon");
            ConsoleHelper.WriteLine("Warming pan...");
            await Task.Delay(5000);
            ConsoleHelper.WriteLine($"{slices} bacon in pan");
            ConsoleHelper.WriteLine("first bacon...");
            await Task.Delay(6000);
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleHelper.WriteLine("flipping bacon");
            }
            ConsoleHelper.WriteLine("second bacon...");
            await Task.Delay(6000);
            ConsoleHelper.WriteLine("bacon ready");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine("bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            ConsoleHelper.WriteLine($"Do {howMany} egg");
            ConsoleHelper.WriteLine("Warming pan...");
            await Task.Delay(4000);
            ConsoleHelper.WriteLine($"{howMany} eggs");
            ConsoleHelper.WriteLine("cooking eggs ...");
            await Task.Delay(16000);
            ConsoleHelper.WriteLine("eggs ready");
            await Task.Delay(1000);
            ConsoleHelper.WriteLine("eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            ConsoleHelper.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}