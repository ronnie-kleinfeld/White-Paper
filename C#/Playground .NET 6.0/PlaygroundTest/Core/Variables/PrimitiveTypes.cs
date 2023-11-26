namespace CoreConsoleApp.Core.Variables
{
    /// <summary>
    /// Primitive types are the one that are native runtime in the CPU
    /// Primitive types inherit from System.ValueType or struct by default
    /// see diagram
    /// </summary>
    public class PrimitiveTypes
    {
        public static void DoUse()
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

            Single s = 32.12f;  // float    -3.4^38,3.4^38
            Double d = 32.12f;  // double   
            Decimal m = 32.12m; // decimal  -7.9^28,7.9^28
        }
    }
}