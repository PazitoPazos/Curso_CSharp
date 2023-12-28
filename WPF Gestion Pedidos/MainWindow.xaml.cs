using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
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
using System.Data;

namespace WPF_Gestion_Pedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;

        private void MuestraClientes()
        {
            string consulta = "SELECT * FROM CLIENTE";
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();
                miAdaptadorSql.Fill(clientesTabla);

                listaClientes.DisplayMemberPath = "nombre";
                listaClientes.SelectedValuePath = "Id";
                listaClientes.ItemsSource = clientesTabla.DefaultView;
            }
        }

        private void MuestraPedidos()
        {
            string consulta = "SELECT * FROM PEDIDO P JOIN CLIENTE C ON C.ID = P.cCliente" +
                " where C.id = @ClienteId";
            SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

            using (miAdaptadorSql)
            {
                sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);
                DataTable pedidosTabla = new DataTable();
                miAdaptadorSql.Fill(pedidosTabla);

                pedidosCliente.DisplayMemberPath = "fechaPedido";
                pedidosCliente.SelectedValuePath = "Id";
                pedidosCliente.ItemsSource = pedidosTabla.DefaultView;
            }
        }

        private void MuestraTodosPedidos()
        {
            string consulta = "SELECT CONCAT(cCliente, ' ', fechaPedido, ' ', formaPago) AS infoCompleta FROM PEDIDO";
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable pedidosTabla = new DataTable();
                miAdaptadorSql.Fill(pedidosTabla);

                todosPedidos.DisplayMemberPath = "infoCompleta";
                todosPedidos.SelectedValuePath = "Id";
                todosPedidos.ItemsSource = pedidosTabla.DefaultView;
            }
        }

        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Has hecho click en un cliente");
            MuestraPedidos();
        }

        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["WPF_Gestion_Pedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            MuestraClientes();
            MuestraTodosPedidos();
        }
    }
}
