namespace PlaygroundTest.Core.Attributes.ClassAttribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SortAttribute : Attribute
    {
        public bool ReverseOrder { get; set; }
    }
}