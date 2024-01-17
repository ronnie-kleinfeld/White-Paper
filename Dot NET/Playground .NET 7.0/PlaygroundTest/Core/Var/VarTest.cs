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

            var ip1 = new Employee();
            IPerson ip2 = new Employee();
            Person ip3 = new Employee();
            Employee ip = new Employee();
        }
    }
}