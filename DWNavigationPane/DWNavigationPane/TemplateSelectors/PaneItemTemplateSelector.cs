using System.Windows;
using System.Windows.Controls;

namespace DWNavigationPane
{
    internal class PaneItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ElementHolderTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is IPaneElementHolder)
            {
                return ElementHolderTemplate;
            }
            return null;
        }
    }
}