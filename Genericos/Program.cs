namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*AlmacenObjetos<DateTime> archivos = new(4);*/
            /*archivos.Agregar("Juan");
            archivos.Agregar("Elena");
            archivos.Agregar("Antonio");
            archivos.Agregar("Sandra");*/

            /*archivos.Agregar(new Empleado(1500));
            archivos.Agregar(new Empleado(2500));
            archivos.Agregar(new Empleado(3500));
            archivos.Agregar(new Empleado(4500));*/

            /*archivos.Agregar(new DateTime());
            archivos.Agregar(new DateTime());
            archivos.Agregar(new DateTime());
            archivos.Agregar(new DateTime());*/

            /*DateTime fecha = archivos.GetDato(2);*/

            /*Console.WriteLine(fecha);*/

            AlmacenEmpleado<Estudiante> empleados = new(3);
            empleados.Agregar(new Estudiante(4500));
            empleados.Agregar(new Estudiante(1500));
            empleados.Agregar(new Estudiante(2500));
        }
    }

    class AlmacenEmpleado<T> where T : IParaEmpleados
    {
        private int i = 0;
        private T[] datos;

        public AlmacenEmpleado(int z) { 
            datos = new T[z];
        }

        public void Agregar(T obj)
        {
            datos[i] = obj;
            i++;
        }

        public T GetEmpleado()
        {
            return datos[i];
        }
    }

    class Director : IParaEmpleados
    {
        private double _salario;

        public Director(double salario) 
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }

    class Secretaria : IParaEmpleados
    {
        private double _salario;

        public Secretaria(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }

    class Electricista : IParaEmpleados
    {
        private double _salario;

        public Electricista(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }

    class Estudiante
    {
        private double _edad;

        public Estudiante(double edad)
        {
            _edad = edad;
        }

        public double GetEdad()
        {
            return _edad;
        }
    }

    interface IParaEmpleados
    {
        double GetSalario();
    }

    class AlmacenObjetos<T>
    {
        private T[] datos;
        private int i = 0;

        public AlmacenObjetos(int z) 
        {
            datos = new T[z];
        }

        public void Agregar(T obj)
        {
            datos[i] = obj;
            i++;
        }

        public T GetDato(int i)
        {
            return datos[i];
        }
    }

    class Empleado
    {
        private double _salario;

        public Empleado(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }
}
