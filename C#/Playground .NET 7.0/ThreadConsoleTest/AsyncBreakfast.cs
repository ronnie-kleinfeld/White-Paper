using System.Runtime.CompilerServices;

namespace ThreadConsoleTest
{
    public class ASyncBreakfast
    {
        static DateTime now = DateTime.Now;

        public static async Task Main()
        {
            Coffee cup = PourCoffee();
            Write("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Write("eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Write("bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    Write("toast is ready");
                }
                await finishedTask;
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            Write("oj is ready");
            Write("Breakfast is ready!");
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
            Write("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Write("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Write("Putting butter on the toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Write("Putting a slice of bread in the toaster");
            }
            Write("Start toasting...");
            await Task.Delay(3000);
            Write("Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Write($"putting {slices} slices of bacon in the pan");
            Write("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Write("flipping a slice of bacon");
            }
            Write("cooking the second side of bacon...");
            await Task.Delay(3000);
            Write("Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Write("Warming the egg pan...");
            await Task.Delay(3000);
            Write($"cracking {howMany} eggs");
            Write("cooking the eggs ...");
            await Task.Delay(3000);
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