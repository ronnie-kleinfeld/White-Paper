namespace PlaygroundTest.Core.DelegatesLambda
{
    [TestClass]
    public class Delegates
    {
        [TestMethod]
        public void UsingADelegate()
        {
            MyDelegate f = Utils.Func1;
            Assert.AreEqual("30", f(10, 20));

            f = Utils.Func2;
            Assert.AreEqual("200", f(10, 20));

            MyClass mc = new MyClass();
            f = mc.instanceMethod1;
            Assert.AreEqual("300", f(10, 20));
        }

        [TestMethod]
        public void InlineDelegate()
        {
            var f1 = delegate (int a, int b)
            {
                return (a - b).ToString();
            };
            Assert.AreEqual("-10", f1(10, 20));

            var f2 = (int a, int b) => (a - b).ToString();
            Assert.AreEqual("-10", f2(10, 20));

            var f3 = (string a, string b) => (a + b).ToString();
            Assert.AreEqual("ab", f3("a", "b"));
        }

        [TestMethod]
        public void ChainOfDelegates()
        {
            MyDelegate f1 = Utils.Func1;
            MyDelegate f2 = Utils.Func2;

            MyDelegate f12 = f1 + f2;
            Assert.AreEqual("30", f1(10, 20));
            Assert.AreEqual("200", f2(10, 20));
            Assert.AreEqual("200", f12(10, 20)); // execute both and return last

            f12 += f1;
            Assert.AreEqual("30", f12(10, 20));

            f12 -= f1;
            Assert.AreEqual("200", f12(10, 20));
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