using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

namespace LINQ_SQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["LINQ_SQL.Properties.Settings.CrudLinqSql"].ConnectionString;
            dataContext = new DataClasses1DataContext(miConexion);
            //InsertarEmpresa();
            //InsertarEmpleado();
            //InsertarCargo();
            //InsertarCargoEmpleado();
            //ActualizarEmpleado();
            EliminarEmpleado();
        }

        public void InsertarEmpresa()
        {
            //dataContext.ExecuteCommand("DELETE FROM Empresa");

            Empresa nuevaEmpresa = new Empresa();
            nuevaEmpresa.Nombre = "Píldoras Informáticas";
            dataContext.Empresa.InsertOnSubmit(nuevaEmpresa);

            Empresa nuevaEmpresa2 = new Empresa();
            nuevaEmpresa2.Nombre = "Google";
            dataContext.Empresa.InsertOnSubmit(nuevaEmpresa2);

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empresa;
        }

        public void InsertarEmpleado()
        {
            //dataContext.ExecuteCommand("DELETE FROM Empresa");
            Empresa pildorasInformaticas = dataContext.Empresa.First(empresa => empresa.Nombre.Equals("Píldoras Informáticas"));
            Empresa google = dataContext.Empresa.First(empresa => empresa.Nombre.Equals("Google"));

            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(new Empleado { Nombre = "Juan", Apellido = "Díaz", EmpresaId = pildorasInformaticas.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Ana", Apellido = "Martínez", EmpresaId = google.Id });
            listaEmpleados.Add(new Empleado { Nombre = "María", Apellido = "López", EmpresaId = google.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Antonio", Apellido = "Fernández", EmpresaId = pildorasInformaticas.Id });

            dataContext.Empleado.InsertAllOnSubmit(listaEmpleados);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleado;
        }

        public void InsertarCargo()
        {
            dataContext.Cargo.InsertOnSubmit(new Cargo { Nombre = "Director/a" });
            dataContext.Cargo.InsertOnSubmit(new Cargo { Nombre = "Administrativo/a" });
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Cargo;
        }

        public void InsertarCargoEmpleado()
        {
            //Empleado Juan = dataContext.Empleado.First(emp => emp.Nombre.Equals("Juan"));
            //Empleado Ana = dataContext.Empleado.First(emp => emp.Nombre.Equals("Ana"));
            //Empleado Maria = dataContext.Empleado.First(emp => emp.Nombre.Equals("María"));
            //Empleado Antonio = dataContext.Empleado.First(emp => emp.Nombre.Equals("Antonio"));
            //Cargo cDirector = dataContext.Cargo.First(cargo => cargo.Nombre.Equals("Director/a"));
            //Cargo cAdministrativo = dataContext.Cargo.First(cargo => cargo.Nombre.Equals("Administrativo/a"));
            //CargoEmpleado cargoJuan = new CargoEmpleado { Empleado = Juan, CargoId = cDirector.Id };
            //CargoEmpleado cargoAna = new CargoEmpleado { Empleado = Ana, CargoId = cAdministrativo.Id };

            List<CargoEmpleado> listaCargosEmpleados = new List<CargoEmpleado>();
            //listaCargosEmpleados.Add(new CargoEmpleado { CargoId = 1, EmpleadoId = 2 });
            //listaCargosEmpleados.Add(new CargoEmpleado { CargoId = 2, EmpleadoId = 3 });
            //listaCargosEmpleados.Add(new CargoEmpleado { CargoId = 1, EmpleadoId = 4 });
            //listaCargosEmpleados.Add(new CargoEmpleado { Cargo = cDirector, Empleado = Ana });
            //listaCargosEmpleados.Add(new CargoEmpleado { Cargo = cAdministrativo, Empleado = María });
            //listaCargosEmpleados.Add(new CargoEmpleado { Cargo = cDirector, Empleado = Antonio });
            listaCargosEmpleados.Add(new CargoEmpleado { 
                Cargo = dataContext.Cargo.First(cargo => cargo.Nombre.Equals("Director/a")), 
                Empleado = dataContext.Empleado.First(emp => emp.Nombre.Equals("Ana")) 
            });
            listaCargosEmpleados.Add(new CargoEmpleado
            {
                Cargo = dataContext.Cargo.First(cargo => cargo.Nombre.Equals("Administrativo/a")),
                Empleado = dataContext.Empleado.First(emp => emp.Nombre.Equals("María"))
            });
            listaCargosEmpleados.Add(new CargoEmpleado
            {
                Cargo = dataContext.Cargo.First(cargo => cargo.Nombre.Equals("Director/a")),
                Empleado = dataContext.Empleado.First(emp => emp.Nombre.Equals("Antonio"))
            });

            dataContext.CargoEmpleado.InsertAllOnSubmit(listaCargosEmpleados);

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.CargoEmpleado;
        }

        public void ActualizarEmpleado()
        {
            Empleado Maria = dataContext.Empleado.First(emp => emp.Nombre.Equals("María"));
            Maria.Nombre = "María Ángeles";
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleado;
        }

        public void EliminarEmpleado()
        {
            Empleado Juan = dataContext.Empleado.First(emp => emp.Nombre.Equals("Juan"));
            dataContext.Empleado.DeleteOnSubmit(Juan);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleado;
        }
    }
}
