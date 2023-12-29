namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] valoresNumericos = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            //Console.WriteLine("Números pares:");
            //IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;
            //foreach (int val in numerosPares)
            //{
            //    Console.WriteLine(val);
            //}

            ControlEmpresaEmpleado cee = new();
            //cee.CEOS();
            //cee.EmpleadosOrdenados();

            Console.Write("Introduce el ID de la empresa: ");
            try
            {
                int entradaId = Convert.ToInt32(Console.ReadLine());
                cee.EmpleadosEmpresa(entradaId);
            } catch (Exception ex)
            {
                Console.WriteLine("Has introducido un ID erróneo");
            }
        }
    }

    class ControlEmpresaEmpleado
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresaEmpleado()
        {
            listaEmpresas = [];
            listaEmpleados = [];

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google"});
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Píldoras Informáticas" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Sergey Brin", Cargo = "CEO", EmpresaId = 1, Salario = 150000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Juan Díaz", Cargo = "CEO", EmpresaId = 2, Salario = 1500000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Larry Page", Cargo = "Co-CEO", EmpresaId = 1, Salario = 150000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Irina Shayk", Cargo = "Co-CEO", EmpresaId = 2, Salario = 1500000 });
        }

        public void CEOS()
        {
            IEnumerable<Empleado> ceos = from emp in listaEmpleados where emp.Cargo == "CEO" select emp;

            foreach (Empleado emp in ceos)
            {
                emp.DatosEmpleado();
            }
        }

        public void EmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from emp in listaEmpleados orderby emp.Nombre select emp;

            foreach (Empleado emp in empleados)
            {
                emp.DatosEmpleado();
            }
        }

        public void EmpleadosEmpresa(int Id)
        {
            IEnumerable<Empleado> empPildoras = from emp in listaEmpleados join empresa in listaEmpresas
                                                on emp.EmpresaId equals empresa.Id
                                                where empresa.Id == Id
                                                select emp;

            foreach (Empleado emp in empPildoras)
            {
                emp.DatosEmpleado();
            }
        }
    }

    class Empresa
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public void DatosEmpresa()
        {
            Console.WriteLine($"Empresa {Nombre} con ID {Id}");
        }
    }

    class Empleado
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
        public double Salario { get; set; }
        public int EmpresaId { get; set; }

        public void DatosEmpleado()
        {
            Console.WriteLine($"Empleado {Nombre} con ID {Id}, cargo {Cargo} con salario {Salario} y perteneciente a la empresa {EmpresaId}");
        }
    }
}
