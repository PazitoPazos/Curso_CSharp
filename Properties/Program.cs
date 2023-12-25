namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");
            Juan.SALARIO = -1200;
            Juan.SALARIO += 500;
            Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);
        }
    }

    class Empleado
    {
        private string _nombre;
        private double _salario;

        /*public double SALARIO
        {
            get { return _salario; }
            set { _salario = evaluaSalario(value); }
        }*/

        public double SALARIO { get => _salario; set => _salario = evaluaSalario(value); }

        public Empleado(string nombre) { 
            _nombre = nombre;
        }

        public void setSalario(double salario)
        {
            if (salario < 0) {
                Console.WriteLine("El salario no puede ser negativo. Se asignará 0 como salario");
            } else
            {
                _salario = salario;
            }
        }

        public double getSalario()
        {
            return _salario;
        }

        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            return salario;
        }
    }
}
