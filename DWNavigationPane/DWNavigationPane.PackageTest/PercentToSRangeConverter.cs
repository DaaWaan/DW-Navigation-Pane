using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Markup;

namespace DWNavigationPane.PackageTest
{
    /// <summary>
    /// Provides multiplication of a bound double to a given factor with a given starting value
    /// </summary>
    public class PercentToSRangeConverter : MarkupExtension, IValueConverter
    {
        #region Fields

        private double from = 0;
        private double to = 0;

        #endregion Fields

        #region Properties

        public double From
        {
            get => from;
            set
            {
                from = value;
                Diff = to - from;
            }
        }

        public double To
        {
            get => to;
            set
            {
                to = value;
                Diff = to - from;
            }
        }

        private double Diff { get; set; }

        #endregion Properties

        #region Interface implementations

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double)value * Diff) + From;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
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
