namespace SharpenedMinecraft.DataTypes
{
    public class Optional<T>
    {
        private bool _HasValue;
        public bool HasValue { get { return _HasValue && Value != null; } set { _HasValue = value; } }
        public T Value { get; set; }
    }
}