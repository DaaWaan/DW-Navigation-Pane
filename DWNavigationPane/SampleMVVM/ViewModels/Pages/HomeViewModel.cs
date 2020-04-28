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
    class HomeViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "Home";

        public Enum Icon => MahApps.Metro.IconPacks.PackIconIoniconsKind.HomeiOS;

        public IPaneElement PaneElement { get; }

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
            var badgedButton = new PaneBadgedButton()
            {
                Icon = Icon,
                Content = DisplayName,
                Command = new RelayCommand<object>((_) => Navigator.SetActivePage(this))
            };
            badgedButton.SetBinding(PaneBadgedButton.BadgeProperty, new Binding("Badge"));
            Badge = 5;
            PaneElement = badgedButton;
        }
    }
}
