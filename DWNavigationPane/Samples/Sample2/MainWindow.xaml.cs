using DWNavigationPane;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

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