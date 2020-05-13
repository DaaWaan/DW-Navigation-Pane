using System.Windows;
using System.Windows.Controls;

namespace DWNavigationPane
{
    /// <summary>
    /// A classic standard Pane with no animations.
    /// </summary>
    public class StaticPane : ContentControl
    {
        static StaticPane()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(StaticPane),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(StaticPane)));
        }
    }
}