namespace CoreConsoleApp.Core.Variables
{
    /// <summary>
    /// Primitive types are the one that are native runtime in the CPU
    /// Primitive types inherit from System.ValueType or struct by default
    /// see diagram
    /// </summary>
    public class PrimitiveTypes
    {
        public static void PT()
        {
            Boolean b1 = true; // {true,false}

            Byte byte1 = 0; // [0,255]
            SByte sb = 0; // [-128,127]

            Char c = 'a';

            Int16 i1 = 1;
            Int32 i2 = 2;
            Int64 i3 = 2;

            UInt16 i4 = 1;
            UInt32 i5 = 2;
            UInt64 i6 = 2;

            Single s = 32.12f; // 32bit single precision floating point number
            Double d = 32.12f; // 64bit double precision floating point number
        }
    }
}