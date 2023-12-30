namespace PlaygroundTest.Core.Lambda
{
    [TestClass]
    public class LambdaTest
    {
        [TestMethod]
        public void UsingADelegate()
        {
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

    // declare the variable type as delegate string(int, int)
    public delegate string MyDelegate(int arg1, int arg2);

    // function to delegate to in an instance of a class
    class MyClass
    {
        public string instanceMethod1(int arg1, int arg2)
        {
            Console.WriteLine("instanceMethod1");
            return ((arg1 + arg2) * arg1).ToString();
        }
    }

    // functions to delegate in a static class
    public static class Utils
    {
        public static string Func1(int a, int b)
        {
            Console.WriteLine("Func1");
            return (a + b).ToString();
        }
        public static string Func2(int a, int b)
        {
            Console.WriteLine("Func2");
            return (a * b).ToString();
        }
    }
}