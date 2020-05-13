using System.Windows;
using System.Windows.Controls;

namespace DWNavigationPane
{
    /// <summary>
    /// Provides the basic properties of a PaneButton
    /// </summary>
    public class PaneButton : Button
    {
        static PaneButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(PaneButton),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: typeof(PaneButton)));
        }
    }
}