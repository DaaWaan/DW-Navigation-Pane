using System.ComponentModel;
using System.Windows;

namespace DWNavigationPane
{
    /// <summary>
    /// An animated Pane that extends when it opens.
    /// </summary>
    public class ExtendingPane : AnimatedPane
    {
        #region Dependency Properties

        #region CompactWidth Property

        /// <summary>
        /// Gets or sets the size of the Pane when compact.
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
            ownerType: typeof(ExtendingPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(double)));

        #endregion CompactWidth Property

        #region ExtendedWidth Property

        /// <summary>
        /// Gets or sets the size of the Pane when compact.
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
            ownerType: typeof(ExtendingPane),
            typeMetadata: new PropertyMetadata(
                defaultValue: default(double)));

        #endregion ExtendedWidth Property

        #endregion Dependency Properties

        static ExtendingPane()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(ExtendingPane),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(ExtendingPane)));
        }
    }
}