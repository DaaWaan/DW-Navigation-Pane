using DWNavigationPane;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sample2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PaneButton_Click(object sender, RoutedEventArgs e)
        {
            PageLabel.Text = (string)((FrameworkElement)sender).ToolTip;
            PageContent.Text = $"{(string)((FrameworkElement)sender).ToolTip} Page";
            Item.SetIcon(IconHolder, Item.GetIcon((DependencyObject)sender));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PageLabel.Text = (string)((MenuItem)sender).Header;
            PageContent.Text = $"{(string)((MenuItem)sender).Header} Page";
            Item.SetIcon(IconHolder, Item.GetIcon((DependencyObject)sender));
        }
    }
}
