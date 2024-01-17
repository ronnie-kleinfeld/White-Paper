namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class CharTest
    {
        [TestMethod]
        public void Char()
        {
            char c1 = 'a';
            Assert.AreEqual('a', c1);
        }

        [TestMethod]
        public void Cast()
        {
            int a = 1;
            char c = 'A';

            Assert.AreEqual("66", $"{a + c}");
            Assert.AreEqual("66", $"{c + a}");
            Assert.AreEqual("B", $"{(char)(c + a)}");
        }

        [TestMethod]
        public void TestMethods()
        {
            Assert.IsTrue(char.IsAscii('a'));
            //Assert.IsTrue(char.IsControl('a'));
            Assert.IsTrue(char.IsDigit('0'));
            //Assert.IsTrue(char.IsHighSurrogate('a'));
            Assert.IsTrue(char.IsLetter('a'));
            Assert.IsTrue(char.IsLetterOrDigit('a'));
            Assert.IsTrue(char.IsLower('a'));
            //Assert.IsTrue(char.IsLowSurrogate('a'));
            Assert.IsTrue(char.IsNumber('1'));
            Assert.IsTrue(char.IsPunctuation(','));
            //Assert.IsTrue(char.IsSeparator(' '));
            //Assert.IsTrue(char.IsSurrogate('a'));
            //Assert.IsTrue(char.IsSurrogatePair('a', 'b'));
            //Assert.IsTrue(char.IsSymbol('!'));
            Assert.IsTrue(char.IsUpper('A'));
            Assert.IsTrue(char.IsWhiteSpace(' '));
        }
    }
}