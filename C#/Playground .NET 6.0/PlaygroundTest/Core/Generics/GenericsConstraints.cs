namespace CoreConsoleApp.Core.Generics
{
    public class GenericsConstraints
    {
        /// <summary>
        /// restricts T to inherit from class or implement an interface
        /// where T : struct        - must be value type
        /// where T : class         - must be a reference type
        /// where T : <base class>  - must inherit from base class
        /// where T : <interface>   - must implement the interface
        /// where T : U             - T must inherit from U
        /// where T : new()         - must have a public parameterless constructor
        /// </summary>
        public int Comparable<T>(T item1, T item2) where T : IComparable
        {
            return item1.CompareTo(item2);
        }
    }
}