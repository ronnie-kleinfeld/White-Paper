namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class VariableCoreTest
    {
        /// <summary>
        /// Primitive types are the one that are native runtime in the CPU
        /// Primitive types inherit from System.ValueType or struct by default
        /// see diagram
        /// </summary>
        [TestMethod]
        public void Primitives()
        {
            Boolean b1 = true; // bool      {true,false}

            Byte byte1 = 0;     // byte     [0,255]
            SByte sb = 0;       // sbyte    [-128,127]

            Char c = 'a';       // char

            Int16 i1 = 1;       // short    [-32767,32767]
            Int32 i2 = 2;       // int      [-2^32,2^32]
            Int64 i3 = 2;       // long     [-2^63,2^63]

            UInt16 i4 = 1;      //          [0,65355]
            UInt32 i5 = 2;
            UInt64 i6 = 2;

            // double is the default type for real number so it does not need a special character with it
            Single s = 32.12f;  // float    -3.4^38,3.4^38
            Double d = 32.12;   // double   
            Decimal m = 32.12m; // decimal  -7.9^28,7.9^28
        }

        [TestMethod]
        public void Range()
        {
            Console.WriteLine($"Boolean bool    [true,false]");
            Console.WriteLine($"Byte    byte    [{byte.MinValue},{byte.MaxValue}]");
            Console.WriteLine($"SByte   sbyte   [{sbyte.MinValue},{sbyte.MaxValue}]");
            Console.WriteLine($"Int16   short   [{Int16.MinValue},{Int16.MaxValue}]");
            Console.WriteLine($"Int32   int     [{Int32.MinValue},{Int32.MaxValue}]");
            Console.WriteLine($"Int64   long    [{Int64.MinValue},{Int64.MaxValue}]");
            Console.WriteLine($"UInt16          [{UInt16.MinValue},{UInt16.MaxValue}]");
            Console.WriteLine($"Single  single  [{Single.MinValue},{Single.MaxValue}]");
            Console.WriteLine($"Double  double  [{Double.MinValue},{Double.MaxValue}]");
            Console.WriteLine($"Decimal decimal [{Decimal.MinValue},{Decimal.MaxValue}]");
        }

        [TestMethod]
        public void Overflow()
        {
            byte number = 255; // max value of 255
            Assert.AreEqual(255, number);
            number++;
            Assert.AreEqual(0, number);

            // checked validate that there is no numeric overflow
            checked
            {
                number = 255;
                Assert.AreEqual(255, number);
                Assert.ThrowsException<OverflowException>(() => number++);
            }
        }
    }
}