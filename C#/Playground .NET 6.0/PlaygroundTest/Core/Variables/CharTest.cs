namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class CharTest
    {
        [TestMethod]
        public void Casr()
        {
            int a = 1;
            char c = 'A';

            Assert.AreEqual("66", $"{a + c}");
            Assert.AreEqual("66", $"{c + a}");
            Assert.AreEqual("B", $"{(char)(c + a)}");
        }
    }
}