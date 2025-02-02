namespace BinaryDataSerialization.Test.Converters
{
    public class ConverterClass
    {
        [FieldOrder(0)]
        public double HalfFieldLength { get; set; }

        [FieldOrder(1)]
        [FieldLength(nameof(HalfFieldLength), ConverterType = typeof(TwiceConverter))]
        public string Field { get; set; }
    }
}
