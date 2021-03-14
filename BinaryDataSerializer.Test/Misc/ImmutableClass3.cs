namespace BinaryDataSerialization.Test.Misc
{
    public class ImmutableClass3
    {
        public ImmutableClass3(int? value)
        {
            Value = value;
        }

        public int? Value { get; }
    }
}
