namespace BinaryDataSerialization.Test.Endianness
{
    public class FieldEndiannessConstClass
    {
        [FieldEndianness(BinaryDataSerialization.Endianness.Big)]
        public int Value { get; set; }
    }
}
