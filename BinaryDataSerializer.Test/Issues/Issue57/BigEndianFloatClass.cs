using BinaryDataSerialization;

namespace BinaryDataSerializer.Test.Issues.Issue57
{
    public class BigEndianFloatClass
    {
        [FieldEndianness(Endianness.Big)]
        public float Value { get; set; }
    }
}
