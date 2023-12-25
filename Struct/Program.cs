namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado(1200, 250);
            Juan.cambiarSalario(Juan, 100);
            Console.WriteLine(Juan);
        }
    }

    struct Empleado
    {
        private double _salarioBase, _comision;

        public double SALARIO_BASE { get => _salarioBase; set => _salarioBase = value; }
        public double COMISION { get => _comision; set => _comision = value; }

        public Empleado(double salarioBase, double comision)
        {
            _salarioBase = salarioBase;
            _comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salario y comisión del empleado ({0}, {1})", SALARIO_BASE, COMISION);
        }

        public void cambiarSalario(Empleado emp, double incremento)
        {
            emp._salarioBase += incremento;
            emp._comision += incremento;
        }
    }
}
