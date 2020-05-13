using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
    public class Extension : DependencyObject
    {
        #region IconSize Property

        /// <summary>
        /// Gets or sets the size of the Pane Icon(s).
        /// </summary>

        public static readonly DependencyProperty IconSizeProperty = DependencyProperty.RegisterAttached(
            name: "IconSize",
            propertyType: typeof(double),
            ownerType: typeof(Extension),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(double),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static double GetIconSize(DependencyObject target) => (double)target.GetValue(IconSizeProperty);

        public static void SetIconSize(DependencyObject target, double value) => target.SetValue(IconSizeProperty, value);

        #endregion IconSize Property
    }
}
