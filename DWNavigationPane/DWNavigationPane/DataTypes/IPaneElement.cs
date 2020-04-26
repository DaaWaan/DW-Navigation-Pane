using System;
using System.Windows.Input;

namespace DWNavigationPane
{
    public interface IPaneElement : IPaneItem
    {
        Enum Icon { get; set; }
        object Content { get; set; }
    }
}