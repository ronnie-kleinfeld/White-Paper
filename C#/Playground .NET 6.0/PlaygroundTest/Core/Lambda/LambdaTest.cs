using PlaygroundTest.Core.DelegatesLambda;

namespace PlaygroundTest.Core.Lambda
{
    [TestClass]
    public class LambdaTest
    {
        [TestMethod]
        public void InlineLambda()
        {
            // inline lambda
            var d1 = (int x) => x * x;
            Assert.AreEqual(25, d1(5));

            // redefine the lambda
            d1 = (x) => x * 10;
            Assert.AreEqual(50, d1(5));

            // lambda that takes multiple arguments
            var d2 = (int x, int y) =>
            {
                return x * y;
            };
            Assert.AreEqual(75, d2(25, 3));
        }
    }
}