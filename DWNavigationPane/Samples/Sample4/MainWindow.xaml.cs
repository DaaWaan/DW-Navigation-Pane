using DWNavigationPane;
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

namespace Sample4
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
