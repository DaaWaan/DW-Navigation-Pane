using DWNavigationPane;
using SampleMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVM.DataTypes
{
    interface IPage : IPaneElementHolder
    {
        Enum Icon { get; }
        string DisplayName { get; }
        string Text { get; }
    }
}
