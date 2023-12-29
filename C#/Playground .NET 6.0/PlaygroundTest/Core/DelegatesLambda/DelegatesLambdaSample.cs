namespace CoreConsoleApp.Core.DelegatesLambda
{
    public class DelegatesLambdaSample
    {
        public static void DoAction()
        {
            var action1 = new Action<int, int>(ActionMethod);

            action1.Invoke(6, 8); // use invoke
            action1(6, 8); // just call
        }
        private static void ActionMethod(int first, int second)
        {
            // do something
        }

        public static void DoFunc()
        {
            var func1 = new Func<int, int, bool>(FuncMethod);

            Console.WriteLine(func1.Invoke(6, 8)); // use invoke
            Console.WriteLine(func1(6, 8)); // just call
        }
        private static bool FuncMethod(int first, int second)
        {
            return first % 2 == 0 && second % 2 == 0;
        }

        public static void DoLambda()
        {
            var lambda1 = new Action<int, int>((first, second) => Console.WriteLine(""));
            var lambda2 = new Func<int, int, bool>((first, second) => first % 2 == 0 && second % 2 == 0);

            lambda1.Invoke(6, 8); // use invoke
            lambda1(6, 8); // just call
            Console.WriteLine(lambda2.Invoke(6, 8)); // use invoke
            Console.WriteLine(lambda2(6, 8)); // just call
        }

        public static void DoLambda2()
        {
            var lambda3 = (string s) => Console.WriteLine(s);
            var lambda4 = (string s) => s.Length;

            lambda3("Hello");
            lambda4("Hello");

            var lambda5 = (string s) =>
            {
                return s.Length;
            };

            GetLambda(lambda4);
        }
        public static void GetLambda(Func<string, int> func)
        {
            func("Hi");
        }

        public static void DoLinq()
        {
            var list = new List<double> { 1.1, 3.3, 5.5 };
            var linq1 = list.Where(num => num > 3);

            Console.WriteLine(list.Count);
            Console.WriteLine(linq1.Count());
        }
    }
}