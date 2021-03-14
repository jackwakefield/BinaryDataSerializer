namespace BinaryDataSerialization.Test.Issues.Issue34
{
    internal class AdditionConverter : IValueConverter
    {
        public object Convert(object value, object parameter, BinaryDataSerializationContext context)
        {
            return System.Convert.ToInt32(value) + System.Convert.ToInt32(parameter);
        }

        public object ConvertBack(object value, object parameter, BinaryDataSerializationContext context)
        {
            return System.Convert.ToInt32(value) - System.Convert.ToInt32(parameter);
        }
    }
}
