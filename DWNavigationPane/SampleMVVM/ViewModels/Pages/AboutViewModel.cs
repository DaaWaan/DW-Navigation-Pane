using DWNavigationPane;
using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using System;

namespace SampleMVVM.ViewModels
{
    internal class AboutViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "About";

        /// <summary>
        /// For Design-time support
        /// </summary>
        public AboutViewModel()
        {
        }

        private INavigator Navigator { get; }

        public AboutViewModel(INavigator navigator)
        {
            Navigator = navigator;
        }
    }
}