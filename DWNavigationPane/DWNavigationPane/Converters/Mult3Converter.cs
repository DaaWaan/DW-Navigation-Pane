﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace DWNavigationPane.Converters
{
    /// <summary>
    /// Provides multiplication of bound values.
    /// </summary>
    internal class Mult3Converter : IMultiValueConverter
    {
        #region Interface implementations

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)values[0] * (double)values[1] * (double)values[2];
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion Interface implementations
    }
}