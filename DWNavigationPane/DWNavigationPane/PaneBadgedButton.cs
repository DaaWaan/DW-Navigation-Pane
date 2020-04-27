using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        protected static readonly DependencyProperty BadgeProperty = DependencyProperty.Register(
            name: "Badge",
            propertyType: typeof(object),
            ownerType: typeof(PaneBadgedButton),
            typeMetadata: new PropertyMetadata(
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
            // Trigger OnBadge Change
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
