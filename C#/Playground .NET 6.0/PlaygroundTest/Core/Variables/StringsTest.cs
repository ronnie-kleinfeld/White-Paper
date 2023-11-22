namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class StringsTest
    {
        [TestMethod]
        public void Init()
        {
            string str1 = "Ronnie";
            string str2 = "Kleinfeld";
            Assert.AreEqual($"{str1} {str2}", "Ronnie Kleinfeld");
        }
    }
}