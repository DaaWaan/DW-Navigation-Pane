using System.ComponentModel;
using System.Windows;

namespace DWNavigationPane
{
    /// <summary>
    /// An Panel that extends when it opens.
    /// </summary>
    public class ExtendingPanel : AnimatedPane
    {
        #region Dependency Properties

        #region CompactWidth Property

        /// <summary>
        /// Gets or sets the size of the Panel when compact.
        /// </summary>
        [Category("Layout")]
        [Description("Gets or sets the size of the Pane when compact.")]
        public double CompactWidth
        {
            get => (double)GetValue(CompactWidthProperty);
            set => SetValue(CompactWidthProperty, value);
        }

        public static readonly DependencyProperty CompactWidthProperty = DependencyProperty.Register(
            name: "CompactWidth",
            propertyType: typeof(double),
            ownerType: typeof(ExtendingPanel),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(double)));

        #endregion CompactWidth Property

        #region ExtendedWidth Property

        /// <summary>
        /// Gets or sets the size of the Panel when extended.
        /// </summary>
        [Category("Layout")]
        [Description("Gets or sets the size of the Pane when compact.")]
        public double ExtendedWidth
        {
            get => (double)GetValue(ExtendedWidthProperty);
            set => SetValue(ExtendedWidthProperty, value);
        }

        public static readonly DependencyProperty ExtendedWidthProperty = DependencyProperty.Register(
            name: "ExtendedWidth",
            propertyType: typeof(double),
            ownerType: typeof(ExtendingPanel),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(double)));

        #endregion ExtendedWidth Property

        #endregion Dependency Properties

        static ExtendingPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(ExtendingPanel),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(ExtendingPanel)));
        }
    }
}