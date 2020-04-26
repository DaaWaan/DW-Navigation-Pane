using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SampleMVVM.Models
{
    interface INavigator
    {
        UserControl ActivePage { get; set; }
        void SetActivePage(IPage page);
    }

    class Navigator : PropertyChangedBase, INavigator
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
