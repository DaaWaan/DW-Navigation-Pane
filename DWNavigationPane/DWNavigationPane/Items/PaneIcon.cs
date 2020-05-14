using System.Windows;
using System.Windows.Controls;

namespace DWNavigationPane
{
    /// <summary>
    /// Provides a container for the PackIconControl
    /// </summary>
    public class PaneIcon : Control
    {
        public override void EndInit()
        {
            base.EndInit();
            Loaded += PaneIconBadge_Loaded;
        }

        /// <summary>
        /// A hack to trigger the BadgeChangedStoryboard at startup.
        ///
        /// MahApps.Metro v1.6.5 badged control currently doesn't have a support for editing the size of
        /// the badge except setting the BadgeChangedStoryboard which is by default uses a ScaleTransform.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaneIconBadge_Loaded(object sender, RoutedEventArgs e)
        {
            if(Item.GetIsBadged(this))
            {
                var badge = Item.GetBadge(this);
                Item.SetBadge(this, 0);
                Item.SetBadge(this, badge);
            }
            Loaded -= PaneIconBadge_Loaded;
        }

        static PaneIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(PaneIcon),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(PaneIcon)));
        }
    }
}