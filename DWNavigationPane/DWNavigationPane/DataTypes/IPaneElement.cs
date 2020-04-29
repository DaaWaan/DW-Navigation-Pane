using System;

namespace DWNavigationPane
{
    public interface IPaneElement : IPaneItem
    {
        Enum Icon { get; set; }
        object Content { get; set; }
    }
}