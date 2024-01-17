namespace PlaygroundTest.Core.Core
{
    [TestClass]
    public class IfElseIIF
    {
        [TestMethod]
        public void Testif()
        {
            Assert.AreEqual(1, DoIf(1));
            Assert.AreEqual(2, DoIf(2));
            Assert.AreEqual(-1, DoIf(3));
        }
        public int DoIf(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else if (input == 2)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        [TestMethod]
        public void TestIIf()
        {
            Assert.AreEqual(true, DoIIf(1));
            Assert.AreEqual(false, DoIIf(2));
        }
        public bool DoIIf(int input)
        {
            return input == 1 ? true : false;
        }
    }
}