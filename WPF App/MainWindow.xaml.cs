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

            List<Capital> ListaCapitales = [];
            ListaCapitales.Add(new Capital { NombreCapital = "Madrid" });
            ListaCapitales.Add(new Capital { NombreCapital = "Bogotá" });
            ListaCapitales.Add(new Capital { NombreCapital = "Lima" });
            ListaCapitales.Add(new Capital { NombreCapital = "DF" });
            ListaCapitales.Add(new Capital { NombreCapital = "Santiago" });
            Capitales.ItemsSource = ListaCapitales;
        }

        public class Capital
        {
            public string? NombreCapital { get; set; }
        }

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;
            DF.IsChecked = true;
            Santiago.IsChecked = true;
        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogota.IsChecked = false;
            Lima.IsChecked = false;
            DF.IsChecked = false;
            Santiago.IsChecked = false;
        }

        private void IndividualChecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true && Bogota.IsChecked == true && Lima.IsChecked == true && DF.IsChecked == true && Santiago.IsChecked == true)
            {
                TodasC.IsChecked = true;
            } else
            {
                TodasC.IsChecked = null;
            }
        }

        private void IndividualNotChecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Bogota.IsChecked == false && Lima.IsChecked == false && DF.IsChecked == false && Santiago.IsChecked == false)
            {
                TodasC.IsChecked = false;
            }
            else
            {
                TodasC.IsChecked = null;
            }
        }
    }
}