namespace ThreadConsoleTest
{
    public class BreakfastAsync
    {
        public static async Task Main()
        {
            Coffee cup = PourCoffee();
            ConsoleWriterHelper.Write("coffee ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    ConsoleWriterHelper.Write("eggs ready");
                }
                else if (finishedTask == baconTask)
                {
                    ConsoleWriterHelper.Write("bacon ready");
                }
                else if (finishedTask == toastTask)
                {
                    ConsoleWriterHelper.Write("toast ready");
                }
                await finishedTask;
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            ConsoleWriterHelper.Write("oj ready");
            ConsoleWriterHelper.Write("Breakfast ready!");
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static Juice PourOJ()
        {
            ConsoleWriterHelper.Write("Pouring OJ");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            ConsoleWriterHelper.Write("jam on toast");

        private static void ApplyButter(Toast toast) =>
            ConsoleWriterHelper.Write("butter on toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.Write("bread in toaster");
            }
            ConsoleWriterHelper.Write("toasting...");
            await Task.Delay(3000);
            ConsoleWriterHelper.Write("Remove toast");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            ConsoleWriterHelper.Write($"{slices} bacon in pan");
            ConsoleWriterHelper.Write("first bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.Write("flipping bacon");
            }
            ConsoleWriterHelper.Write("second bacon...");
            await Task.Delay(3000);
            ConsoleWriterHelper.Write("bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            ConsoleWriterHelper.Write("Warming pan...");
            await Task.Delay(3000);
            ConsoleWriterHelper.Write($"cracking {howMany} eggs");
            ConsoleWriterHelper.Write("cooking eggs ...");
            await Task.Delay(3000);
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