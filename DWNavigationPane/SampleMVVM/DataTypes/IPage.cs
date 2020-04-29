using DWNavigationPane;
using System;

namespace SampleMVVM.DataTypes
{
    internal interface IPage : IPaneElementHolder
    {
        Enum Icon { get; }
        string DisplayName { get; }
    }
}