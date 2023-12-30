namespace PlaygroundTest.Core.DelegatesLambda
{
    [TestClass]
    public class ActionAndFuncTest
    {
        [TestMethod]
        public void ActionTest()
        {
            var action1 = new Action<int, int>(ActionMethod);

            action1.Invoke(6, 8); // use invoke
            action1(6, 8); // just call

            var action2 = new Action<int, int>((first, second) => Console.WriteLine(""));

            action2.Invoke(6, 8); // use invoke
            action2(6, 8); // just call
        }

        [TestMethod]
        public void FuncTest()
        {
            var func1 = new Func<int, int, int>(FuncMethod);

            Assert.AreEqual(30, func1.Invoke(10, 20));
            Assert.AreEqual(30, func1(10, 20));

            var func2 = new Func<int, int, int>((first, second) => first * second);
            Assert.AreEqual(200, func2.Invoke(10, 20));
            Assert.AreEqual(200, func2(10, 20));
        }

        private static void ActionMethod(int first, int second)
        {
            Console.WriteLine("do something, Action do not return a value");
        }

        private static int FuncMethod(int first, int second)
        {
            return first + second;
        }
    }
}