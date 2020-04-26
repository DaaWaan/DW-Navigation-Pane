using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DWNavigationPane
{
    internal class PaneItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ElementHolderTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if(item is IPaneElementHolder)
            {
                return ElementHolderTemplate;
            }
            return null;
        }
    }
}
