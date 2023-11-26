namespace CoreConsoleApp.Core.Variables
{
    /// <summary>
    /// Nullable type
    /// Converts a value type (struct) to be able to have a value of null | empty
    ///     public struct Nullable<T> where T : struct
    /// </summary> <summary>
    /// 
    /// </summary>
    public class NullableTypes
    {
        public static void DoUse()
        {
            var taxRate = new Nullable<double>();
            Console.WriteLine(taxRate.HasValue); // fals e
            Console.WriteLine(taxRate); // empty
            Console.WriteLine(taxRate.GetValueOrDefault()); // 0
            taxRate = null;
            Console.WriteLine(taxRate); // empty
            taxRate = 0.2;
            Console.WriteLine(taxRate); // 0.2
            Console.WriteLine(taxRate.Value); // 0.2
            taxRate = null;
            Console.WriteLine(taxRate); // empty
        }

        public static void DoUseQuestion()
        {
            double? taxRate = null;
            Console.WriteLine(taxRate.HasValue); // false
            Console.WriteLine(taxRate); // empty
            Console.WriteLine(taxRate.GetValueOrDefault()); // 0
            taxRate = null;
            Console.WriteLine(taxRate); // empty
            taxRate = 0.2;
            Console.WriteLine(taxRate); // 0.2
            Console.WriteLine(taxRate.Value); // 0.2
            taxRate = null;
            Console.WriteLine(taxRate); // empty
        }
    }
}