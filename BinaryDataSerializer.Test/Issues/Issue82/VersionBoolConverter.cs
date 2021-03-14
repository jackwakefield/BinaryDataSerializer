using System;

namespace BinaryDataSerialization.Test.Issues.Issue82
{
    class VersionBoolConverter : IValueConverter
    {
        public object Convert(object value, object parameter, BinaryDataSerializationContext context)
        {
            var version = (int)value;
            var minVersion = (int)parameter;

            return version > minVersion;
        }

        public object ConvertBack(object value, object parameter, BinaryDataSerializationContext context)
        {
            throw new NotSupportedException();
        }
    }
}
