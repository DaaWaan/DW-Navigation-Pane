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

        public Enum Icon => MahApps.Metro.IconPacks.PackIconIoniconsKind.InformationCircleOutlineiOS;

        public IPaneElement PaneElement { get; }

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
            PaneElement = new DWNavigationPane.PaneButton()
            {
                Icon = Icon,
                Content = DisplayName,
                Command = new RelayCommand<object>((_) => Navigator.SetActivePage(this))
            };
        }
    }
}