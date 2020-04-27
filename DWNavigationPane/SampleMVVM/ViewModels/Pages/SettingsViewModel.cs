using DWNavigationPane;
using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SampleMVVM.ViewModels
{
    class SettingsViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "Settings";

        public string Text => $"{DisplayName} Page";

        public Enum Icon => MahApps.Metro.IconPacks.PackIconIoniconsKind.SettingsiOS;

        private IPaneElement paneElement;
        public IPaneElement PaneElement => paneElement;

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
            var badgedButton = new PaneBadgedButton()
            {
                Icon = Icon,
                Content = DisplayName,
                Command = new RelayCommand<object>((_) => Navigator.SetActivePage(this))
            };
            badgedButton.SetBinding(PaneBadgedButton.BadgeProperty, new Binding("Badge"));
            Badge = 1;
            paneElement = badgedButton;
        }
    }
}
