namespace ThreadConsoleTest.Tasks
{
    internal class Bacon { }
    internal class Coffee { }
    internal class Egg { }
    internal class Juice { }
    internal class Toast { }

    public class BreakfastSync
    {
        internal static async Task Cook(string[] args)
        {
            Coffee cup = PourCoffee();
            ConsoleWriterHelper.Write("coffee ready");

            Egg eggs = FryEggs(2);
            ConsoleWriterHelper.Write("eggs ready");

            Bacon bacon = FryBacon(3);
            ConsoleWriterHelper.Write("bacon ready");

            Toast toast = ToastBread(2);
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

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.Write("bread in toaster");
            }
            ConsoleWriterHelper.Write("toasting...");
            Task.Delay(3000).Wait();
            ConsoleWriterHelper.Write("Remove toast");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            ConsoleWriterHelper.Write($"{slices} bacon in pan");
            ConsoleWriterHelper.Write("first bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.Write("flipping bacon");
            }
            ConsoleWriterHelper.Write("second bacon...");
            Task.Delay(3000).Wait();
            ConsoleWriterHelper.Write("bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            ConsoleWriterHelper.Write("Warming pan...");
            Task.Delay(3000).Wait();
            ConsoleWriterHelper.Write($"{howMany} eggs");
            ConsoleWriterHelper.Write("cooking eggs ...");
            Task.Delay(3000).Wait();
            ConsoleWriterHelper.Write("eggs plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            ConsoleWriterHelper.Write("Pouring coffee");
            return new Coffee();
        }
    }
}