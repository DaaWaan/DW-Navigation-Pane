using DWNavigationPane;
using System.Windows;

namespace Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void ItemClick(object sender, RoutedEventArgs e)
        {
            var Sender = sender as IPaneElement;
            if (Sender != null)
            {
                PageLabel.Text = $"{Sender.Content} Page";
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}