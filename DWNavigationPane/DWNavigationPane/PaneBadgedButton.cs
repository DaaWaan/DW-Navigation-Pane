using MahApps.Metro.Controls;
using System.ComponentModel;
using System.Windows;

namespace DWNavigationPane
{
    [TemplatePart(Name = "PART_Badge", Type = typeof(Badged))]
    public class PaneBadgedButton : PaneButton
    {
        #region Dependency Properties

        #region Badge Property

        [Category("Common")]
        [Description("Gets or sets the badge of the item")]
        public object Badge
        {
            get => (object)GetValue(BadgeProperty);
            set => SetValue(BadgeProperty, value);
        }

        public static readonly DependencyProperty BadgeProperty = DependencyProperty.Register(
            name: "Badge",
            propertyType: typeof(object),
            ownerType: typeof(PaneBadgedButton),
            typeMetadata: new FrameworkPropertyMetadata(
                defaultValue: default));

        #endregion Badge Property

        #endregion Dependency Properties

        public override void EndInit()
        {
            base.EndInit();
            Loaded += PaneBadgedButton_Loaded;
        }

        private void PaneBadgedButton_Loaded(object sender, RoutedEventArgs e)
        {
            var tempBadge = Badge;
            Badge = 0;
            Badge = tempBadge;
            Loaded -= PaneBadgedButton_Loaded;
        }

        static PaneBadgedButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(PaneBadgedButton),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(PaneBadgedButton)));
        }
    }
}