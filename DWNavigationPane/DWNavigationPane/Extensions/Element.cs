using System.Windows;
using System.Windows.Media;

namespace DWNavigationPane
{
    /// <summary>
    /// Provides inheritable attached framework-level set of properties for all DW Navigation Pane controls.
    /// </summary>
    public static class Element
    {
        #region Inheritable Attached Properties

        #region IconSize Property

        /// <summary>
        /// Gets or sets the size of the Pane Icon(s).
        /// </summary>

        public static readonly DependencyProperty IconSizeProperty = DependencyProperty.RegisterAttached(
            name: "IconSize",
            propertyType: typeof(double),
            ownerType: typeof(Element),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(double),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static double GetIconSize(DependencyObject target) => (double)target.GetValue(IconSizeProperty);

        public static void SetIconSize(DependencyObject target, double value) => target.SetValue(IconSizeProperty, value);

        #endregion IconSize Property

        #region IconContainerSize Property

        /// <summary>
        /// Gets or sets the size of the Pane Icon Container(s).
        /// </summary>

        public static readonly DependencyProperty IconContainerSizeProperty = DependencyProperty.RegisterAttached(
            name: "IconContainerSize",
            propertyType: typeof(double),
            ownerType: typeof(Element),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(double),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static double GetIconContainerSize(DependencyObject target) => (double)target.GetValue(IconContainerSizeProperty);

        public static void SetIconContainerSize(DependencyObject target, double value) => target.SetValue(IconContainerSizeProperty, value);

        #endregion IconContainerSize Property

        #region BackgroundHover Property

        /// <summary>
        /// Gets or sets the background when hovered over by the mouse.
        /// </summary>

        public static readonly DependencyProperty BackgroundHoverProperty = DependencyProperty.RegisterAttached(
            name: "BackgroundHover",
            propertyType: typeof(Brush),
            ownerType: typeof(Element),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(Brush),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static Brush GetBackgroundHover(DependencyObject target) => (Brush)target.GetValue(BackgroundHoverProperty);

        public static void SetBackgroundHover(DependencyObject target, Brush value) => target.SetValue(BackgroundHoverProperty, value);

        #endregion BackgroundHover Property

        #region ForegroundHover Property

        /// <summary>
        /// Gets or sets the foreground when hovered over by the mouse.
        /// </summary>

        public static readonly DependencyProperty ForegroundHoverProperty = DependencyProperty.RegisterAttached(
            name: "ForegroundHover",
            propertyType: typeof(Brush),
            ownerType: typeof(Element),
            defaultMetadata: new FrameworkPropertyMetadata(
                defaultValue: default(Brush),
                flags: FrameworkPropertyMetadataOptions.Inherits));

        public static Brush GetForegroundHover(DependencyObject target) => (Brush)target.GetValue(ForegroundHoverProperty);

        public static void SetForegroundHover(DependencyObject target, Brush value) => target.SetValue(ForegroundHoverProperty, value);

        #endregion ForegroundHover Property

        #endregion Inheritable Attached Properties
    }
}