using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Sample2
{
    /// <summary>
    /// Provides inversion of percentage.
    /// </summary>
    internal class InvertPercentConverter : MarkupExtension, IValueConverter
    {
        #region Interface Implementations

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 1 - (double)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion Interface Implementations

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}