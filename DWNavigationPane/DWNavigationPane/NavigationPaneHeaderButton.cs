using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWNavigationPane
{
    /// <summary>
    ///
    /// NavigationPaneHeaderButton class was created to prevent the Header button from
    /// being styled in the resources as NavigationPaneItem:
    ///
    /// <--! dwnav:NavigationPane>
    ///     <dwnav:NavigationPane.Resources>
    ///         <Style TargetType="{x:Type dwnav:NavigationPaneItem}">
    ///             . . . <!-- All setters here won't affect the header button -->
    ///         </Style>
    ///     </NavigationPane.Resources>
    /// </dwnav:NavigationPane -->
    ///
    /// </summary>
    internal class NavigationPaneHeaderButton : NavigationPaneItem
    {
    }
}
