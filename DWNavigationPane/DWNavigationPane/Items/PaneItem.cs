using System.Windows;
using System.Windows.Controls;

namespace DWNavigationPane
{
    /// <summary>
    /// Provides the basic properties of a PaneItem
    /// </summary>
    public class PaneItem : ContentControl
    {
        public override void EndInit()
        {
            base.EndInit();
            Loaded += PaneIcon.PaneIconBadge_Loaded;
        }

        static PaneItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(PaneItem),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(PaneItem)));
        }
    }
}