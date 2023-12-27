using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_App
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

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            ERojo.Visibility = Visibility.Visible;
            EAmbar.Visibility = Visibility.Hidden;
            EVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            ERojo.Visibility = Visibility.Hidden;
            EAmbar.Visibility = Visibility.Visible;
            EVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            ERojo.Visibility = Visibility.Hidden;
            EAmbar.Visibility = Visibility.Hidden;
            EVerde.Visibility = Visibility.Visible;
        }
    }
}