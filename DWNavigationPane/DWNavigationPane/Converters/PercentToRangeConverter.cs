using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace DWNavigationPane.Converters
{
    /// <summary>
    /// Provides multiplication of a bound double to a bound factor with a bound starting value
    /// </summary>
    public class PercentToRangeConverter : MarkupExtension, IMultiValueConverter
    {
        #region Interface implementations

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)values[0] * ((double)values[2] - (double)values[1]) + (double)values[1];
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        #endregion Interface implementations
    }
}