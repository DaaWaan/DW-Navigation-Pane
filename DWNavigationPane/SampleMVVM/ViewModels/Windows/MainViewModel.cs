using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using SampleMVVM.ViewModels;
using DWNavigationPane;

namespace SampleMVVM
{
    internal class MainViewModel : PropertyChangedBase
    {
        private Navigator navigator = new Navigator();

        public Navigator Navigator
        {
            get => navigator;
            set => SetAndNotify(ref navigator, value);
        }

        private PageCollection Pages = new PageCollection();

        public MainViewModel()
        {
            Pages.Add(new HomeViewModel(Navigator));
            Pages.Add(new SearchViewModel(Navigator));
            Pages.Add(new EditViewModel(Navigator));
            Pages.Add(new AboutViewModel(Navigator));
            Pages.Add(new SettingsViewModel(Navigator));

            Navigator.SetActivePage(Pages[0]);
        }
    }
}