using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using System.Windows.Controls;

namespace SampleMVVM.Models
{
    internal interface INavigator
    {
        UserControl ActivePage { get; set; }

        void SetActivePage(IPage page);
    }

    internal class Navigator : PropertyChangedBase, INavigator
    {
        private PageManager pageManager = new PageManager();

        private UserControl activePage;

        public UserControl ActivePage
        {
            get => activePage;
            set => SetAndNotify(ref activePage, value);
        }

        public void SetActivePage(IPage page)
        {
            ActivePage = pageManager.GetViewPage(page);
            ActivePage.DataContext = page;
        }
    }
}