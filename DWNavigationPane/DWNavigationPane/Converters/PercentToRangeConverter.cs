using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace DWNavigationPane
{
    internal class PercentToRangeConverter : DependencyObject, IMultiValueConverter
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

        #endregion Interface implementations
    }
}