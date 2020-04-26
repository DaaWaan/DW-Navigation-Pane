using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWNavigationPane
{
    /// <summary>
    ///
    /// PaneHeaderButton class was created to prevent the Header button from
    /// being styled in the resources as PaneButton:
    ///
    /// <--! dwnav:NavigationPane>
    ///     <dwnav:NavigationPane.Resources>
    ///         <Style TargetType="{x:Type dwnav:PaneButton}">
    ///             . . . <!-- All setters here won't affect the header button -->
    ///         </Style>
    ///     </NavigationPane.Resources>
    /// </dwnav:NavigationPane -->
    ///
    /// </summary>
    internal class PaneHeaderButton : PaneButton
    {
    }
}
