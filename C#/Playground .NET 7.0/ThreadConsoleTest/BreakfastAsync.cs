namespace ThreadConsoleTest
{
    public class BreakfastAsync
    {
        static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            ConsoleWriterHelper.Write("coffee ready");

            ConsoleWriterHelper.Write("making eggs");
            Task<Egg> eggsTask = FryEggsAsync(6);

            ConsoleWriterHelper.Write("making bacon");
            Task<Bacon> baconTask = FryBaconAsync(7);

            ConsoleWriterHelper.Write("making toast");
            Task<Toast> toastTask = ToastBreadAsync(4);

            Egg eggs = await eggsTask;
            ConsoleWriterHelper.Write("eggs ready");

            Bacon bacon = await baconTask;
            ConsoleWriterHelper.Write("bacon ready");

            Toast toast = await toastTask;
            ApplyButter(toast);
            ApplyJam(toast);
            ConsoleWriterHelper.Write("toast ready");

            Juice oj = PourOJ();
            ConsoleWriterHelper.Write("oj ready");


            ConsoleWriterHelper.Write("Breakfast ready!");

            ConsoleWriterHelper.WriteFinish();
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
            ConsoleWriterHelper.Write("Do toast");
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
            ConsoleWriterHelper.Write("Do bacon");
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
            ConsoleWriterHelper.Write("Do egg");
            ConsoleWriterHelper.Write("Warming pan...");
            await Task.Delay(3000);
            ConsoleWriterHelper.Write($"{howMany} eggs");
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