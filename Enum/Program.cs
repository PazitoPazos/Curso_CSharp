namespace Enum
{
    enum Estaciones { Primavera, Verano, Otoño, Invierno };
    enum Bonus { Bajo = 500, Normal = 1000, Bueno = 1500, Extra = 2000 };

    internal class Program
    {
        static void Main(string[] args)
        {
            //Estaciones? alergia = null;
            //string La_alergia = alergia.ToString();
            //Console.WriteLine(alergia);

            //Bonus Antonio = Bonus.Bueno;
            //double bonusAntonio = (double) Antonio;
            //double salarioAntonio = 1500 + bonusAntonio;
            //Console.WriteLine(salarioAntonio);

            Empleado Juan = new(Bonus.Extra, 1900.50);
            Console.WriteLine("El salario del empleado es: " + Juan.GetSalario());
        }
    }

    class Empleado
    {
        private double _salario;
        private Bonus _bonus;

        public Empleado(Bonus bonus, double salario)
        {
            _bonus = bonus;
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario + (double) _bonus;
        }
    }
}
