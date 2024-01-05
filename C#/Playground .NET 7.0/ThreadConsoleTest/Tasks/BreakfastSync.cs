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
            ConsoleWriterHelper.WriteLine("coffee ready");

            Egg eggs = FryEggs(2);
            ConsoleWriterHelper.WriteLine("eggs ready");

            Bacon bacon = FryBacon(3);
            ConsoleWriterHelper.WriteLine("bacon ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            ConsoleWriterHelper.WriteLine("toast ready");

            Juice oj = PourOJ();
            ConsoleWriterHelper.WriteLine("oj ready");
            ConsoleWriterHelper.WriteLine("Breakfast ready!");

            ConsoleWriterHelper.WriteFinish();
        }

        private static Juice PourOJ()
        {
            ConsoleWriterHelper.WriteLine("Pouring OJ");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            ConsoleWriterHelper.WriteLine("jam on toast");

        private static void ApplyButter(Toast toast) =>
            ConsoleWriterHelper.WriteLine("butter on toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.WriteLine("bread in toaster");
            }
            ConsoleWriterHelper.WriteLine("toasting...");
            Task.Delay(3000).Wait();
            ConsoleWriterHelper.WriteLine("Remove toast");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            ConsoleWriterHelper.WriteLine($"{slices} bacon in pan");
            ConsoleWriterHelper.WriteLine("first bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleWriterHelper.WriteLine("flipping bacon");
            }
            ConsoleWriterHelper.WriteLine("second bacon...");
            Task.Delay(3000).Wait();
            ConsoleWriterHelper.WriteLine("bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            ConsoleWriterHelper.WriteLine("Warming pan...");
            Task.Delay(3000).Wait();
            ConsoleWriterHelper.WriteLine($"{howMany} eggs");
            ConsoleWriterHelper.WriteLine("cooking eggs ...");
            Task.Delay(3000).Wait();
            ConsoleWriterHelper.WriteLine("eggs plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            ConsoleWriterHelper.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}