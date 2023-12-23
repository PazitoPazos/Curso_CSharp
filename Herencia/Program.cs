namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caballo Babieca = new("Babieca");
            //Humano Juan = new("Juan");
            //Gorila Copito = new("Copito");

            // Principio de sustitución
            //Mamifero caballo = new Caballo("Bucéfalo");
            //Mamifero persona = new Humano("Sara");
            //Mamifero gorila = new Gorila("Gorila");

            //Mamifero[] mamiferos = [caballo, persona, gorila];

            //foreach (Mamifero mamifero in mamiferos)
            //{
            //    mamifero.Pensar();
            //}

            Console.WriteLine("Probando el avión...");
            Avion miAvion = new Avion();
            miAvion.Arrancar("tracatracatraca");
            miAvion.Despegar();
            miAvion.Conducir();
            miAvion.Aterrizar();
            miAvion.Parar("plooof");

            Console.WriteLine();

            Console.WriteLine("Probando el coche...");
            Coche miCoche = new Coche();
            miCoche.Arrancar("grrrrum grrrruuumm");
            miCoche.Acelerar();
            miCoche.Conducir();
            miCoche.Frenar();
            miCoche.Parar("bluuuf");

            Console.WriteLine();

            Console.WriteLine("Haciendo polimorfismo");
            Vehiculo miVehiculo = miCoche;
            miVehiculo.Conducir();
            miVehiculo = miAvion;
            miVehiculo.Conducir();
        }
    }

    class Mamifero(string nombre)
    {
        public string NombreSerVivo { get; set; } = nombre;

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo básico");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías");
        }
    }

    class Caballo(string nombre) : Mamifero(nombre)
    {
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano(string nombre) : Mamifero(nombre)
    {
        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila(string nombre) : Mamifero(nombre)
    {
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
