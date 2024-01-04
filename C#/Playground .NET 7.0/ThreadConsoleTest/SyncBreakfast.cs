using System.Runtime.CompilerServices;

namespace ThreadConsoleTest
{
    // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
    internal class Bacon { }
    internal class Coffee { }
    internal class Egg { }
    internal class Juice { }
    internal class Toast { }

    public class SyncBreakfast
    {
        static DateTime now = DateTime.Now;

        public static void Main()
        {
            Coffee cup = PourCoffee();
            Write("coffee is ready");

            Egg eggs = FryEggs(2);
            Write("eggs are ready");

            Bacon bacon = FryBacon(3);
            Write("bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Write("toast is ready");

            Juice oj = PourOJ();
            Write("oj is ready");
            Write("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            Write("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Write("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Write("Putting butter on the toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Write("Putting a slice of bread in the toaster");
            }
            Write("Start toasting...");
            Task.Delay(3000).Wait();
            Write("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Write($"putting {slices} slices of bacon in the pan");
            Write("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Write("flipping a slice of bacon");
            }
            Write("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Write("Put bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            Write("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Write($"cracking {howMany} eggs");
            Write("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Write("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Write("Pouring coffee");
            return new Coffee();
        }

        private static void Write(string message, [CallerMemberName] string memberName = "")
        {
            double diff = (DateTime.Now - now).TotalSeconds;
            Console.WriteLine($"{diff,11:F2} - {memberName}: {message}");
        }
    }
}