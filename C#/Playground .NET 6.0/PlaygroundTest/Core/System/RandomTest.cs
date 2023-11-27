namespace PlaygroundTest.Core.System
{
    [TestClass]
    public class RandomTest
    {
        [TestMethod]
        public void Init()
        {
            Random r = new Random();
            int i = r.Next(0, 1);
            Assert.IsTrue(i >= 0 && i <= 1);
        }
    }
}