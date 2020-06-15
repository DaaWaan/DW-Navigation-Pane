using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace DWNavigationPane.Converters
{
    /// <summary>
    /// Provides multiplication of a double to a factor.
    /// </summary>
    public class ScaleConverter : MarkupExtension, IValueConverter
    {
        public double Factor { get; set; }

        #region Interface Implementations

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value * Factor;
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