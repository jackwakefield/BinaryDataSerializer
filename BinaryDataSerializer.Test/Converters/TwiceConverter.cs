namespace BinaryDataSerialization.Test.Converters
{
    public class TwiceConverter : IValueConverter
    {
        public object Convert(object value, object converterParameter, BinaryDataSerializationContext ctx)
        {
            var a = System.Convert.ToDouble(value);
            return a * 2;
        }

        public object ConvertBack(object value, object converterParameter, BinaryDataSerializationContext ctx)
        {
            var a = System.Convert.ToDouble(value);
            return a / 2;
        }
    }
}
