using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVM.ViewModels
{
    class SettingsViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "Settings";

        public string Text => $"{DisplayName} Page";

        public Enum Icon => MahApps.Metro.IconPacks.PackIconIoniconsKind.SettingsiOS;

        private DWNavigationPane.IPaneElement paneElement;
        public DWNavigationPane.IPaneElement PaneElement => paneElement;

        /// <summary>
        /// For Design-time support
        /// </summary>
        public SettingsViewModel()
        {
            paneElement = new DWNavigationPane.PaneButton()
            {
                Icon = Icon,
                Content = DisplayName
            };
        }

        private INavigator Navigator { get; }

        public SettingsViewModel(INavigator navigator)
        {
            Navigator = navigator;
            paneElement = new DWNavigationPane.PaneButton()
            {
                Icon = Icon,
                Content = DisplayName,
                Command = new RelayCommand<IPage>(Navigator.SetActivePage),
                CommandParameter = this
            };
        }
    }
}
