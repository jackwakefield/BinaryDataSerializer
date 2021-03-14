using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml.Data;
using BinaryDataSerializer.Editor.ViewModels;

namespace BinaryDataSerializer.Editor.Converters
{
    public class BindingListConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return null;
            }

            var bindings = (IList<BindingViewModel>)value;
            var bindingKinds = bindings.Select(binding => binding.Kind.ToString()).Distinct();
            return string.Join(", ", bindingKinds);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
