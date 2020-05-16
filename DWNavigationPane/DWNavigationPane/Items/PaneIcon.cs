using System.Runtime.Remoting.Channels;
using System.Windows;
using System.Windows.Controls;

namespace DWNavigationPane
{
    /// <summary>
    /// Provides a container for the PackIconControl
    /// </summary>
    public class PaneIcon : Control
    {
        /// <summary>
        /// A hack to trigger the BadgeChangedStoryboard at startup.
        /// </summary>
        /// <remarks>
        /// MahApps.Metro v1.6.5 badged control currently doesn't have a support for editing the size of
        /// the badge except setting the BadgeChangedStoryboard which is by default uses a ScaleTransform.
        /// However, the transformation isn't applied at startup until a new badge is set. A simple hack is to
        /// set a dummy value for the Item at startup.
        /// </remarks>
        /// <param name="_sender"></param>
        /// <param name="e"></param>
        public static void PaneIconBadge_Loaded(object _sender, RoutedEventArgs e)
        {
            FrameworkElement sender = _sender as FrameworkElement;
            if(Item.GetIconTemplate(sender) == IconTemplate.Badged)
            {
                object badge = Item.GetBadge(sender);
                Item.SetBadge(sender, 0);
                Item.SetBadge(sender, badge);
            }
            sender.Loaded -= PaneIconBadge_Loaded;
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