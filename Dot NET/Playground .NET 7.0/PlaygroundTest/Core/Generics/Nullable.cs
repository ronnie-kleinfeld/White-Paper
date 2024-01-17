namespace PlaygroundTest.Core.Generics
{
    public struct Nullable<T> where T : struct
    {
        private object _value;

        public Nullable(object value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            return default(T);
        }
    }
}
