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

        public Enum Icon => MahApps.Metro.IconPacks.PackIconIoniconsKind.OpeniOS;

        public IPaneElement PaneElement { get; }

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
            PaneElement = new PaneButton()
            {
                Icon = Icon,
                Content = DisplayName,
                Command = new RelayCommand<object>((_) => Navigator.SetActivePage(this))
            };
        }
    }
}