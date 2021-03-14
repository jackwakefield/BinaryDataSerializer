using System;

namespace BinaryDataSerialization.Test.Encoding
{
    public class EncodingConverter : IValueConverter
    {
        public object Convert(object value, object parameter, BinaryDataSerializationContext context)
        {
            var encodingName = (string)value;
            return EncodingHelper.GetEncoding(encodingName);
        }

        public object ConvertBack(object value, object parameter, BinaryDataSerializationContext context)
        {
            throw new NotSupportedException();
        }
    }
}
