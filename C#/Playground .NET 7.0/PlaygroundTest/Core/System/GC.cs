namespace PlaygroundTest.Core.System
{
    [TestClass]
    public class GCTest
    {
        [TestMethod]
        public void GCCollectSample()
        {
            GC.Collect();

            long before = GC.GetTotalMemory(false);

            DoSomeBigOperation();
            long during = GC.GetTotalMemory(false);
            Assert.IsTrue(during > before);

            GC.Collect();

            long after = GC.GetTotalMemory(false);
            Assert.IsTrue(after < during);
        }

        void DoSomeBigOperation()
        {
            byte[] myArray = new byte[1000000];
        }
    }
}