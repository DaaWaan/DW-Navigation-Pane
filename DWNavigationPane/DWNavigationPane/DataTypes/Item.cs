using System.Windows;
using System.Windows.Media;

namespace DWNavigationPane
{
    /// <summary>
    /// Provides attached properties for a Pane item.
    /// </summary>
    public static class Item
    {
        #region Attached properties

        #region Icon Property

        /// <summary>
        /// Gets or sets the icon of the Pane item.
        /// </summary>

        public static readonly DependencyProperty IconProperty = DependencyProperty.RegisterAttached(
            name: "Icon",
            propertyType: typeof(object),
            ownerType: typeof(Item),
            defaultMetadata: new PropertyMetadata(
                defaultValue: default));

        public static object GetIcon(DependencyObject target) => target.GetValue(IconProperty);

        public static void SetIcon(DependencyObject target, object value) => target.SetValue(IconProperty, value);

        #endregion Icon Property

        #region IsIconOnly Property

        /// <summary>
        /// Gets or sets if the Pane Item contains an Icon only.
        /// </summary>

        public static readonly DependencyProperty IsIconOnlyProperty = DependencyProperty.RegisterAttached(
            name: "IsIconOnly",
            propertyType: typeof(bool),
            ownerType: typeof(Item),
            defaultMetadata: new PropertyMetadata(
                defaultValue: false));

        public static bool GetIsIconOnly(DependencyObject target) => (bool)target.GetValue(IsIconOnlyProperty);

        public static void SetIsIconOnly(DependencyObject target, bool value) => target.SetValue(IsIconOnlyProperty, value);

        #endregion IsIconOnly Property

        #region Badge Property

        /// <summary>
        /// Gets or sets the badge of the Pane item.
        /// </summary>

        public static readonly DependencyProperty BadgeProperty = DependencyProperty.RegisterAttached(
            name: "Badge",
            propertyType: typeof(object),
            ownerType: typeof(Item),
            defaultMetadata: new PropertyMetadata(
                defaultValue: default));

        public static object GetBadge(DependencyObject target) => target.GetValue(BadgeProperty);

        public static void SetBadge(DependencyObject target, object value) => target.SetValue(BadgeProperty, value);

        #endregion Badge Property

        #region IsBadged Property

        /// <summary>
        /// Gets or sets if the Pane Item supports a badge.
        /// </summary>

        public static readonly DependencyProperty IsBadgedProperty = DependencyProperty.RegisterAttached(
            name: "IsBadged",
            propertyType: typeof(bool),
            ownerType: typeof(Item),
            defaultMetadata: new PropertyMetadata(
                defaultValue: false));

        public static bool GetIsBadged(DependencyObject target) => (bool)target.GetValue(IsBadgedProperty);

        public static void SetIsBadged(DependencyObject target, bool value) => target.SetValue(IsBadgedProperty, value);

        #endregion IsBadged Property

        #region Background Property

        /// <summary>
        /// Gets or sets the background for the Item. This background is applied to the Item before the Trigger for hover.
        /// </summary>

        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached(
            name: "Background",
            propertyType: typeof(Brush),
            ownerType: typeof(Item),
            defaultMetadata: new PropertyMetadata(
                defaultValue: default(Brush)));

        public static Brush GetBackground(DependencyObject target) => (Brush)target.GetValue(BackgroundProperty);

        public static void SetBackground(DependencyObject target, Brush value) => target.SetValue(BackgroundProperty, value);

        #endregion BackgroundAlt Property

        #region Foreground Property

        /// <summary>
        /// Gets or sets the foreground for the Item. This foreground is applied to the Item before the Trigger for hover.
        /// </summary>

        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached(
            name: "Foreground",
            propertyType: typeof(Brush),
            ownerType: typeof(Item),
            defaultMetadata: new PropertyMetadata(
                defaultValue: default(Brush)));

        public static Brush GetForeground(DependencyObject target) => (Brush)target.GetValue(ForegroundProperty);

        public static void SetForeground(DependencyObject target, Brush value) => target.SetValue(ForegroundProperty, value);

        #endregion Foreground Property

        #endregion Attached properties
    }
}