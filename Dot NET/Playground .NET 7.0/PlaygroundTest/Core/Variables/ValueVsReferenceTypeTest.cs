namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class ValueVsReferenceTypeTest
    {
        /// <summary>
        /// value type called in method, did NOT change original values
        /// </summary>
        [TestMethod]
        public void ValueType()
        {
            MyStruct s1;
            s1.a = 5;
            s1.b = false;

            Assert.AreEqual(s1.a, 5);
            Assert.AreEqual(s1.b, false);
            StructOperation(s1);
            Assert.AreEqual(s1.a, 5);
            Assert.AreEqual(s1.b, false);
        }

        void StructOperation(MyStruct s2)
        {
            s2.a = 10;
            s2.b = true;
            Assert.AreEqual(s2.a, 10);
            Assert.AreEqual(s2.b, true);
        }

        /// <summary>
        /// reference type called in method, did change original values
        /// </summary>
        [TestMethod]
        public void ReferenceType()
        {
            MyClass c1 = new MyClass();
            c1.a = 5;
            c1.b = false;

            Assert.AreEqual(c1.a, 5);
            Assert.AreEqual(c1.b, false);
            ClassOperation(c1);
            Assert.AreEqual(c1.a, 10);
            Assert.AreEqual(c1.b, true);
        }

        void ClassOperation(MyClass c2)
        {
            c2.a = 10;
            c2.b = true;
            Assert.AreEqual(c2.a, 10);
            Assert.AreEqual(c2.b, true);
        }
    }

    public struct MyStruct
    {
        public int a;
        public bool b;
    }

    public class MyClass
    {
        public int a;
        public bool b;
    }
}