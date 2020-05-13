using DWNavigationPane;
using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using System;
using System.Windows.Data;

namespace SampleMVVM.ViewModels
{
    internal class HomeViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "Home";

        private uint? badge;

        public uint? Badge
        {
            get => (badge != 0) ? badge : null;
            set => SetAndNotify(ref badge, value);
        }

        /// <summary>
        /// For Design-time support
        /// </summary>
        public HomeViewModel()
        {
        }

        private INavigator Navigator { get; }

        public HomeViewModel(INavigator navigator)
        {
            Navigator = navigator;
        }
    }
}