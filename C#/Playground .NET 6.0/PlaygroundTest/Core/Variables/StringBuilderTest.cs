using System.ComponentModel;
using System.Text;

namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class StringBuilderTest
    {
        [TestMethod]
        public void Init()
        {
            StringBuilder sb = new StringBuilder();

            Assert.AreEqual(0, sb.Length);
        }
    }
}