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

            List<Poblaciones> ListaPob = [];
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17, DiferenciaTemp = 2 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Valencia", Poblacion2 = "Alicante", Temperatura1 = 19, Temperatura2 = 20, DiferenciaTemp = 1 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Málaga", Poblacion2 = "Bilbao", Temperatura1 = 20, Temperatura2 = 7, DiferenciaTemp = 13 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Sevilla", Poblacion2 = "Coruña", Temperatura1 = 22, Temperatura2 = 8, DiferenciaTemp = 14 });
            ListaPoblaciones.ItemsSource = ListaPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones)?.Poblacion1 + " " +
                (ListaPoblaciones.SelectedItem as Poblaciones)?.Temperatura1 + "ºC " +
                (ListaPoblaciones.SelectedItem as Poblaciones)?.Poblacion2 + " " +
                (ListaPoblaciones.SelectedItem as Poblaciones)?.Temperatura2 + "ºC");
            } else
            {
                MessageBox.Show("Selecciona un elemento");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones)?.Poblacion1 + " " +
                (ListaPoblaciones.SelectedItem as Poblaciones)?.Temperatura1 + "ºC " +
                (ListaPoblaciones.SelectedItem as Poblaciones)?.Poblacion2 + " " +
                (ListaPoblaciones.SelectedItem as Poblaciones)?.Temperatura2 + "ºC");
            } else
            {
                MessageBox.Show("Selecciona un elemento");
            }
        }
    }

    public class Poblaciones
    {
        public string? Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }
        public string? Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }

        public int DiferenciaTemp {  get; set; }
    }
}