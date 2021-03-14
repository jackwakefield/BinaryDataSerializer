using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using BinaryDataSerializer.Editor.ViewModels;

namespace BinaryDataSerializer.Editor.Controls
{
    public class FieldTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ValueTemplate { get; set; }

        public DataTemplate CollectionTemplate { get; set; }

        public DataTemplate ClassTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is CollectionViewModel)
            {
                return CollectionTemplate;
            }

            if (item is ClassViewModel)
            {
                return ClassTemplate;
            }

            if (item is FieldViewModel)
            {
                return ValueTemplate;
            }

            return base.SelectTemplateCore(item);
        }
    }
}
