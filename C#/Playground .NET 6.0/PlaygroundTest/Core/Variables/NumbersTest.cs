using System.ComponentModel;

namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void Init()
        {
            Byte byte1 = 0; // [0,255]
            SByte sb = 0; // [-128,127]

            Int16 i1 = 1;
            Int32 i2 = 2;
            Int64 i3 = 2;

            UInt16 i4 = 1;
            UInt32 i5 = 2;
            UInt64 i6 = 2;

            Single s = 32.12f; // 32bit single precision floating point number
            Double d = 32.12f; // 64bit double precision floating point number

            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void Parse()
        {
            string[] NumStrs = { "  1 ", " 1.45  ", "-100", "5e+04 " };

            int i1;
            float f1;
            bool result;

            foreach (string str in NumStrs)
            {
                try
                {
                    f1 = float.Parse(str);
                    Console.WriteLine($"Parsed string \"{str}\" to float is {f1}");
                    i1 = int.Parse(str);
                    Console.WriteLine($"Parsed string \"{str}\" to int is {i1}");
                } catch (FormatException e)
                {
                    Console.WriteLine($"Could not parse \"{str}\" : {e.Message}");
                }
            }

            foreach (string str in NumStrs)
            {
                result = float.TryParse(str, out f1);
                Console.WriteLine($"{result} -- float.TryParse '{str}' : {f1}");

                result = int.TryParse(str, out i1);
                Console.WriteLine($"{result} -- int.TryParse '{str}' : {i1}");
            }
        }
    }
}