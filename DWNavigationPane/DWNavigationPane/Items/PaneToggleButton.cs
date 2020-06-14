using System.Windows;
using System.Windows.Controls.Primitives;

namespace DWNavigationPane
{
    /// <summary>
    /// Provides the basic properties of a PaneToggleButton
    /// </summary>
    public class PaneToggleButton : ToggleButton
    {
        static PaneToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(PaneToggleButton),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(PaneToggleButton)));
        }
    }
}