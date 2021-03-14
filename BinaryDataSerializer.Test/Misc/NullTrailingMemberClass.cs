namespace BinaryDataSerialization.Test.Misc
{
    public class NullTrailingMemberClass : NullTrailingMemberClassBase
    {
        [FieldOrder(0)]
        public int Value { get; set; }

        [FieldOrder(1)]
        public byte? OptionalParameter { get; set; }
    }
}
