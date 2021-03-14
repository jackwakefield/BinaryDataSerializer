using BinaryDataSerialization;

namespace BinaryDataSerializer.Performance
{
    public class TwiceConverter : IValueConverter
    {
        public object Convert(object value, object converterParameter, BinaryDataSerializationContext ctx)
        {
            var a = System.Convert.ToInt32(value);
            return a * 2;
        }

        public object ConvertBack(object value, object converterParameter, BinaryDataSerializationContext ctx)
        {
            var a = System.Convert.ToInt32(value);
            return a / 2;
        }
    }
}
