namespace ThreadConsoleTest
{
    public class BreakfastAsync
    {
        internal static async Task Cook(string[] args)
        {
            Coffee cup = PourCoffee();
            ConsoleWriterHelper.Write("coffee ready");

            //await CallTasksSequantialy();
            await CallTasksWhenAll();

            Juice oj = PourOJ();
            ConsoleWriterHelper.Write("oj ready");

            ConsoleWriterHelper.Write("Breakfast ready!");

            ConsoleWriterHelper.WriteFinish();
        }

        private static async Task CallTasksSequantialy()
        {
            ConsoleWriterHelper.Write("making toast");
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(3);

            ConsoleWriterHelper.Write("making eggs");
            Task<Egg> eggsTask = FryEggsAsync(5);

            ConsoleWriterHelper.Write("making bacon");
            Task<Bacon> baconTask = FryBaconAsync(6);

            Egg eggs = await eggsTask;
            ConsoleWriterHelper.Write("eggs ready");

            Bacon bacon = await baconTask;
            ConsoleWriterHelper.Write("bacon ready");

            Toast toast = await toastTask;
            ConsoleWriterHelper.Write("toast ready");
        }
        private static async Task CallTasksWhenAll()
        {
            ConsoleWriterHelper.Write("making toast");
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(3);

            ConsoleWriterHelper.Write("making eggs");
            Task<Egg> eggsTask = FryEggsAsync(5);

            ConsoleWriterHelper.Write("making bacon");
            Task<Bacon> baconTask = FryBaconAsync(6);

            await Task.WhenAll(eggsTask, baconTask, toastTask);
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