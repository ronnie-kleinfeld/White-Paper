namespace PlaygroundTest.Core
{
    [TestClass]
    public class ForForeachDoWhile
    {
        [TestMethod]
        public void For()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += i;
            }
            Assert.AreEqual(1 + 2 + 3 + 4, sum);
        }

        [TestMethod]
        public void ForEach()
        {
            string str = "Ronnie";
            string name = string.Empty;

            foreach (char c in str)
            {
                name += c;
            }
            Assert.AreEqual("Ronnie", name);
        }

        [TestMethod]
        public void While()
        {
            int count = 1;

            while (count < 2)
            {
                count++;
            }

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Do()
        {
            int count = 1;

            do
            {
                count++;
            } while (count < 2);

            Assert.AreEqual(2, count);
        }
    }
}