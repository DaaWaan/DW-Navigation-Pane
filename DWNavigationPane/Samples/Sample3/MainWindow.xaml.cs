using DWNavigationPane;
using System.Windows;

namespace Sample3
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

        private string previousSenderText = "Explorer";

        private void PaneButton_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            if (!MainPanel.IsOpen)
            {
                MainPanel.IsOpen = true;
            }
            else if (previousSenderText == (string)element.ToolTip)
            {
                MainPanel.IsOpen = false;
                return;
            }
            MainPanelTitle.Text = ((string)element.ToolTip).ToUpper();
            Item.SetIcon(MainPanelIconHolder, Item.GetIcon(element));
            previousSenderText = (string)element.ToolTip;
        }
    }
}