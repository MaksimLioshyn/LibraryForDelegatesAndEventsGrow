using System.Windows;

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
    }
}
