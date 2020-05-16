using DWNavigationPane;
using System;
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
            previousSender = MyHomeButton;
            Item.SetIsActive(previousSender, true);
        }

        private DependencyObject previousSender;

        private void PaneButton_Click(object sender, RoutedEventArgs e)
        {
            PageLabel.Text = (string)((FrameworkElement)sender).ToolTip;
            PageContent.Text = $"{(string)((FrameworkElement)sender).ToolTip} Page";
            Item.SetIcon(IconHolder, Item.GetIcon((DependencyObject)sender));

            Item.SetIsActive(previousSender, false);
            previousSender = (DependencyObject)sender;
            Item.SetIsActive(previousSender, true);

            double? badge = Convert.ToDouble(Item.GetBadge(previousSender));
            NumericUpDown.Value = ((badge == 0) ? null : badge);
        }

        private void NumericUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if(previousSender != null)
                Item.SetBadge(previousSender, (e.NewValue == 0) ? null : e.NewValue);
        }
    }
}