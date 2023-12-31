using System.Runtime.CompilerServices;

namespace PlaygroundTest.Core.Attributes
{
    [TestClass]
    public class AttributesTest
    {
        [TestMethod]
        public void Init()
        {
            SomeMethod("Ronnie", 2);
            Assert.AreEqual(1, 1);
        }

        public void SomeMethod(string name, int id, [CallerArgumentExpression("name")] string arg = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0,
            [CallerMemberName] string memberName = "")
        {
            Assert.AreEqual("Init", memberName);

            Console.WriteLine(arg);
            Console.WriteLine(filePath);
            Console.WriteLine(lineNumber);
            Console.WriteLine(memberName);
        }
    }
}