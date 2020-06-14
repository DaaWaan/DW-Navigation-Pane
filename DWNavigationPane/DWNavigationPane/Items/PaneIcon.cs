using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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
            Loaded += PaneIcon_Loaded;
        }

        /// <summary>
        /// Triggers the BadgeChangedStoryboard at startup.
        /// </summary>
        /// <remarks>
        /// The BadgeChangedStoryboard is not triggered when the Badged control is initialized.
        /// This raises issues where the badge looks different when the badge is changed.
        /// Triggering the BadgeChangedStoryboard at startup will show the expected layout of a Badge at it's initial state.
        /// </remarks>
        /// <param name="_sender"></param>
        /// <param name="e"></param>
        public static void PaneIcon_Loaded(object _sender, RoutedEventArgs e)
        {
            FrameworkElement sender = _sender as FrameworkElement;
            if (Item.GetIconTemplate(sender) == IconTemplate.Badged)
            {
                // Store previous instance of binding because this will be removed
                // when a DependencyProperty is manually assigned with a value in code-behind
                Binding binding = BindingOperations.GetBinding(sender, Item.BadgeProperty);

                object badge = Item.GetBadge(sender);
                Item.SetBadge(sender, 0);
                Item.SetBadge(sender, badge);

                if (binding != null)
                    BindingOperations.SetBinding(sender, Item.BadgeProperty, binding);
            }
            sender.Loaded -= PaneIcon_Loaded;
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