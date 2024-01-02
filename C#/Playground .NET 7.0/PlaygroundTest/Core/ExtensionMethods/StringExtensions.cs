namespace PlaygroundTest.Core.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string WithoutSpaces(this String str)
        {
            return str.Replace(" ", "");
        }

        public static string ReplaceSpaces(this String str, char from, char to)
        {
            return str.Replace(from, to);
        }
    }
}
