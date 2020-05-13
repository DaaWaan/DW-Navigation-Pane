using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace DWNavigationPane.Converters
{
    /// <summary>
    /// Provides checking if value is null.
    /// </summary>
    internal class IsNullConverter : MarkupExtension, IValueConverter
    {
        #region Interface Implementations

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value == null);
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