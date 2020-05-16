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
            previousSender = ExplorerButton;
            Item.SetIsActive(previousSender, true);
        }

        private string previousSenderText = "Explorer";
        private DependencyObject previousSender;

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
                Item.SetIsActive(element, false);
                return;
            }

            Item.SetIsActive(previousSender, false);
            Item.SetIsActive(element, true);
            MainPanelTitle.Text = ((string)element.ToolTip).ToUpper();
            Item.SetIcon(MainPanelIconHolder, Item.GetIcon(element));
            previousSenderText = (string)element.ToolTip;

            previousSender = (DependencyObject)sender;
        }
    }
}