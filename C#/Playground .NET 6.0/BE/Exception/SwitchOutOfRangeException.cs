using System.Reflection;

namespace BE.Exceptions
{
    [Serializable]
    public class SwitchOutOfRangeException : ExceptionEx
    {
        // class
        public SwitchOutOfRangeException(MethodBase method, object data) : base(null, method, data, "Switch value {0} is out of range", data)
        {
        }
    }
}