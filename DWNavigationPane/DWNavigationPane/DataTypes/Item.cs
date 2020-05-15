using System.Windows;
using System.Windows.Media;

namespace DWNavigationPane
{
    /// <summary>
    /// Indicates the template of the Icon of the Pane Item
    /// </summary>
    public enum IconTemplate
    {
        Default = 0,
        Badged
    }

    /// <summary>
    /// Indicates the template of the Pane Item
    /// </summary>
    public enum ItemTemplate
    {
        Default = 0,
        IconOnly,
        ContentOnly
    }

    /// <summary>
    /// Provides attached properties for a Pane item.
    /// </summary>
    public static class Item
    {
        #region Attached properties

        #region IconTemplate Property

        /// <summary>
        /// Gets or sets the template for the Icon of the Pane Item.
        /// </summary>

        public static readonly DependencyProperty IconTemplateProperty = DependencyProperty.RegisterAttached(
            name: "IconTemplate",
            propertyType: typeof(IconTemplate),
            ownerType: typeof(Item),
            defaultMetadata: new PropertyMetadata(
                defaultValue: IconTemplate.Default));

        public static IconTemplate GetIconTemplate(DependencyObject target) => (IconTemplate)target.GetValue(IconTemplateProperty);

        public static void SetIconTemplate(DependencyObject target, IconTemplate value) => target.SetValue(IconTemplateProperty, value);

        #endregion IconTemplate Property

        #region ItemTemplate Property

        /// <summary>
        /// Gets or sets the template for the Pane Item.
        /// </summary>

        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.RegisterAttached(
            name: "ItemTemplate",
            propertyType: typeof(ItemTemplate),
            ownerType: typeof(Item),
            defaultMetadata: new PropertyMetadata(
                defaultValue: ItemTemplate.Default));

        public static ItemTemplate GetItemTemplate(DependencyObject target) => (ItemTemplate)target.GetValue(ItemTemplateProperty);

        public static void SetItemTemplate(DependencyObject target, ItemTemplate value) => target.SetValue(ItemTemplateProperty, value);

        #endregion IconTemplate Property

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