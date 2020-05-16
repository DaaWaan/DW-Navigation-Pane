using DWNavigationPane;
using System.Windows;

namespace Sample1
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
    }
}
