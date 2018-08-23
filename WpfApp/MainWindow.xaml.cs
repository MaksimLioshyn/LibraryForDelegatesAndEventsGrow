using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfApp
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

        private void showHideBtn_Click(object sender, RoutedEventArgs e)
        {
            ImageTest.Visibility = !ImageTest.IsVisible ? Visibility.Visible : Visibility.Hidden;
        }

        private void increaseBtn_Click(object sender, RoutedEventArgs e)
        {
            ImageTest.Height = ActualHeight * 1.1;
            ImageTest.Width = ActualWidth * 1.1;
        }

        private void DecreaseBtn_OnClickcreaseBtn_Click(object sender, RoutedEventArgs e)
        {
            ImageTest.Height = ActualHeight * 0.8;
            ImageTest.Width = ActualWidth * 0.8;
        }
    }
}
