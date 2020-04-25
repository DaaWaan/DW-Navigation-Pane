using System;
using System.Windows.Input;

namespace DWNavigationPane
{
    public interface INavigationPaneItem
    {
        Enum Icon { get; }
        object Content { get; }
        ICommand Command { get; }
    }
}