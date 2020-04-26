using DWNavigationPane;
using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using SampleMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace SampleMVVM
{
    class MainViewModel : PropertyChangedBase
    {
        private Navigator navigator = new Navigator();
        public Navigator Navigator
        {
            get => navigator;
            set => SetAndNotify(ref navigator, value);
        }

        private PageCollection Pages = new PageCollection();

        private DWNavigationPane.PaneItemCollection mainMenuPages = new DWNavigationPane.PaneItemCollection();
        public DWNavigationPane.PaneItemCollection MainMenuPages
        {
            get => mainMenuPages;
            set => SetAndNotify(ref mainMenuPages, value);
        }

        private DWNavigationPane.PaneItemCollection bottomMenuPages = new DWNavigationPane.PaneItemCollection();
        public DWNavigationPane.PaneItemCollection BottomMenuPages
        {
            get => bottomMenuPages;
            set => SetAndNotify(ref bottomMenuPages, value);
        }

        public MainViewModel()
        {
            Pages.Add(new HomeViewModel(Navigator));
            Pages.Add(new SearchViewModel(Navigator));
            Pages.Add(new EditViewModel(Navigator));
            Pages.Add(new AboutViewModel(Navigator));
            Pages.Add(new SettingsViewModel(Navigator));

            MainMenuPages.Add(Pages[0]);
            MainMenuPages.Add(Pages[1]);
            MainMenuPages.Add(Pages[2]);
            BottomMenuPages.Add(Pages[3]);
            BottomMenuPages.Add(Pages[4]);

            Navigator.SetActivePage(Pages[0]);
        }
    }
}
