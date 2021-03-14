using System;

namespace BinaryDataSerialization.Test.Endianness
{
    public class InvalidEndiannessConverter : IValueConverter
    {
        public object Convert(object value, object parameter, BinaryDataSerializationContext context)
        {
            return 0;
        }

        public object ConvertBack(object value, object parameter, BinaryDataSerializationContext context)
        {
            throw new NotImplementedException();
        }
    }
}
