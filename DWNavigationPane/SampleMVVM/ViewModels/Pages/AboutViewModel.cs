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
    class AboutViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "About";

        public string Text => $"{DisplayName} Page";

        public Enum Icon => MahApps.Metro.IconPacks.PackIconIoniconsKind.InformationCircleOutlineiOS;

        private DWNavigationPane.IPaneElement paneElement;
        public DWNavigationPane.IPaneElement PaneElement => paneElement;

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
            paneElement = new DWNavigationPane.PaneButton()
            {
                Icon = Icon,
                Content = DisplayName,
                Command = new RelayCommand<object>((_) => Navigator.SetActivePage(this))
            };
        }
    }
}
