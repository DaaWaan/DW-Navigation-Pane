using DWNavigationPane;
using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using System;
using System.Windows.Data;

namespace SampleMVVM.ViewModels
{
    internal class SettingsViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "Settings";

        private uint? badge;

        public uint? Badge
        {
            get => (badge != 0) ? badge : null;
            set => SetAndNotify(ref badge, value);
        }

        /// <summary>
        /// For Design-time support
        /// </summary>
        public SettingsViewModel()
        {
        }

        private INavigator Navigator { get; }

        public SettingsViewModel(INavigator navigator)
        {
            Navigator = navigator;
        }
    }
}