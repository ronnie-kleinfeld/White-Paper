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
            ConsoleHelper.WriteLine("coffee ready");

            Egg eggs = FryEggs(2);
            ConsoleHelper.WriteLine("eggs ready");

            Bacon bacon = FryBacon(3);
            ConsoleHelper.WriteLine("bacon ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            ConsoleHelper.WriteLine("toast ready");

            Juice oj = PourOJ();
            ConsoleHelper.WriteLine("oj ready");
            ConsoleHelper.WriteLine("Breakfast ready!");
        }

        private static Coffee PourCoffee()
        {
            ConsoleHelper.WriteLine("Pouring coffee");
            return new Coffee();
        }

        private static Egg FryEggs(int howMany)
        {
            ConsoleHelper.WriteLine("Warming pan...");
            Task.Delay(2000).Wait();
            ConsoleHelper.WriteLine($"{howMany} eggs");
            ConsoleHelper.WriteLine("cooking eggs ...");
            Task.Delay(2000).Wait();
            ConsoleHelper.WriteLine("eggs plate");

            return new Egg();
        }

        private static Bacon FryBacon(int slices)
        {
            ConsoleHelper.WriteLine($"{slices} bacon in pan");
            ConsoleHelper.WriteLine("first bacon...");
            Task.Delay(2000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleHelper.WriteLine("flipping bacon");
            }
            ConsoleHelper.WriteLine("second bacon...");
            Task.Delay(2000).Wait();
            ConsoleHelper.WriteLine("bacon on plate");

            return new Bacon();
        }

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                ConsoleHelper.WriteLine("bread in toaster");
            }
            ConsoleHelper.WriteLine("toasting...");
            Task.Delay(2000).Wait();
            ConsoleHelper.WriteLine("Remove toast");

            return new Toast();
        }
        private static void ApplyJam(Toast toast) =>
            ConsoleHelper.WriteLine("jam on toast");

        private static void ApplyButter(Toast toast) =>
            ConsoleHelper.WriteLine("butter on toast");

        private static Juice PourOJ()
        {
            ConsoleHelper.WriteLine("Pouring OJ");
            return new Juice();
        }
    }
}