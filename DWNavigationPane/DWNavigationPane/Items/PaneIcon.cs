using System.Windows;
using System.Windows.Controls;

namespace DWNavigationPane
{
    public class PaneIcon : Control
    {
        static PaneIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(PaneIcon),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(PaneIcon)));
        }
    }
}