using DWNavigationPane;
using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using System;

namespace SampleMVVM.ViewModels
{
    internal class EditViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "Edit";

        /// <summary>
        /// For Design-time support
        /// </summary>
        public EditViewModel()
        {
        }

        private INavigator Navigator { get; }

        public EditViewModel(INavigator navigator)
        {
            Navigator = navigator;
        }
    }
}