using SampleMVVM.DataTypes;
using SampleMVVM.ViewModels;
using SampleMVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SampleMVVM.Models
{
    class PageManager
    {
        private List<UserControl> Views = new List<UserControl>();

        public PageManager()
        {
            Views.Add(new AboutView());
            Views.Add(new EditView());
            Views.Add(new HomeView());
            Views.Add(new SearchView());
            Views.Add(new SettingsView());
        }

        public UserControl GetViewPage(IPage Page)
        {
            return Views.First(view => Page.GetType().Name.Contains(view.GetType().Name));
        }
    }
}
