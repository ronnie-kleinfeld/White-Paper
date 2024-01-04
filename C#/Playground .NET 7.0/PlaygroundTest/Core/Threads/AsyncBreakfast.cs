using System.Diagnostics;

namespace PlaygroundTest.Core.Threads
{
    [TestClass]
    public class AsyncBreakfast
    {
        [TestMethod]
        public static async Task Main()
        {
            Coffee cup = PourCoffeeAsync(100);
            Console.Write("coffee is ready\r\n");
            var eggTask = FryEggsAsync(3000);
            var baconTask = FryBaconAsync(4001);
            var toastTask = maketoastWithButterAndJamAsync(5001, 4001, 4001);

            var allTasks = new List<Task> { eggTask, baconTask, toastTask };
            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == eggTask)
                {
                    Console.Write("eggs are ready\r\n");
                    allTasks.Remove(eggTask);
                    var eggs = await eggTask;
                }
                else if (finished == baconTask)
                {
                    Console.Write("bacon is ready\r\n");
                    allTasks.Remove(baconTask);
                    var bacon = await baconTask;
                }
                else if (finished == toastTask)
                {
                    Console.Write("toast is finally ready :)\r\n");
                    allTasks.Remove(toastTask);
                    var toast = await toastTask;
                }
                else
                    allTasks.Remove(finished);
            }

            Juice oj = PourOjAsync(100);
            Console.Write("oj is ready\r\n");

            Console.Write("Breakfast is ready!");

            async Task<Toast> maketoastWithButterAndJamAsync(int toasted, int butter, int jam)
            {
                var plainToast = await ToastBreadAsync(toasted, butter, jam);
                await ApplyButter(plainToast, butter);
                await ApplyJam(plainToast, jam);
                return plainToast;
            }
        }

        public static Coffee PourCoffeeAsync(int x)
        {
            string cookingAction = "Pouring Coffee";
            var delay = Task.Run(async () =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.Delay(x);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });
            Console.WriteLine("{0} took {1} minutes to make:", cookingAction, delay.Result / 1000);
            Console.ReadLine();
            return new Coffee();
        }

        public static async Task<Egg> FryEggsAsync(int x)
        {
            string cookingAction = "Frying Eggs";
            var delay = Task.Run(async () =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.Delay(x);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });
            var duration = await delay;
            Console.WriteLine("{0} took {1} minutes to make:", cookingAction, duration / 1000);
            return new Egg();
        }

        public static async Task<Bacon> FryBaconAsync(int x)
        {
            string cookingAction = "Frying Bacon";
            var delay = Task.Run(async () =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.Delay(x);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });
            var duration = await delay;
            Console.WriteLine("{0} took {1} minutes to make:", cookingAction, duration / 1000);
            return new Bacon();
        }

        public static async Task<Toast> ToastBreadAsync(int toasted, int butter, int jam)
        {
            string cookingAction = "Toasting Bread";
            var delay = Task.Run(async () =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.Delay(toasted);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });
            var duration = await delay;
            Console.WriteLine("{0} took {1} minutes to make:", cookingAction, duration / 1000);
            return new Toast(toasted, butter, jam);
        }

        public static async Task<Toast> ApplyButter(Toast x, int butter)
        {
            var delay = Task.Run(async () =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.Delay(butter);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });
            var duration = await delay;
            Console.Write("applying butter took {0} minutes\r\n", duration / 1000);
            Console.Write("Applying butter & toasting the bread has taken " + ((x._toasted + x._buttered) / 1000) + " minutes\r\n");
            return new Toast();
        }

        public static async Task<Toast> ApplyJam(Toast x, int jam)
        {
            var delay = Task.Run(async () =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.Delay(jam);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });
            var duration = await delay;
            Console.Write("applying jam took {0} minutes\r\n", duration / 1000);
            Console.Write("Applying butter, jam & toasting the bread has taken a total of " + ((x._toasted + x._buttered + x._jammed) / 1000) + " minutes\r\n");
            return new Toast();
        }

        public static Juice PourOjAsync(int x)
        {
            string cookingAction = "Pouring Oj";
            var delay = Task.Run(async () =>
            {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.Delay(x);
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });
            Console.WriteLine("{0} took {1} minutes to make:", cookingAction, delay.Result / 1000);
            return new Juice();
        }

        public class Coffee
        {
        }

        public class Egg
        {
        }

        public class Bacon
        {
        }

        public class Toast
        {
            public readonly int _toasted;
            public readonly int _buttered;
            public readonly int _jammed;
            public Toast(int toasted = 0, int butter = 0, int jam = 0)
            {
                _toasted = toasted;
                _buttered = butter;
                _jammed = jam;
            }
        }

        public class Juice
        {
        }
    }
}