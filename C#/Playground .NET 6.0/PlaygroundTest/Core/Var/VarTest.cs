namespace PlaygroundTest.Core.Var
{
    [TestClass]
    public class VarTest
    {
        [TestMethod]
        public void Init()
        {
            var p1 = new Employee();
            Assert.AreEqual("Employee Do1A", p1.Do1A());
        }
    }
}