namespace ThreadConsoleTest
{
    public class BreakfastAsync
    {
        static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            ConsoleWriterHelper.Write("coffee ready");

            ConsoleWriterHelper.Write("making eggs");
            Egg eggs = await FryEggsAsync(2);
            ConsoleWriterHelper.Write("eggs ready");

            ConsoleWriterHelper.Write("making bacon");
            Bacon bacon = await FryBaconAsync(3);
            ConsoleWriterHelper.Write("bacon ready");

            ConsoleWriterHelper.Write("making toast");
            Toast toast = await ToastBreadAsync(2);
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