using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace DWNavigationPane.Converters
{
    /// <summary>
    /// Provides multiplication of double to a fraction.
    /// </summary>
    public class ScaleFractionConverter : MarkupExtension, IValueConverter
    {
        public double Numerator { get; set; }
        public double Denominator { get; set; }

        #region Interface Implementations

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value * (Numerator / Denominator);
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