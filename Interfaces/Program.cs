namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caballo miCaballo = new("Caballo");
            // Usar el principio de sustitución para acceder a los métodos de cada interfaz en caso de ambigüedad
            //IMamiferosTerrestres IMiCaballo = miCaballo;
            //Console.WriteLine("Número de patas: " + IMiCaballo.NumeroPatas());

            //ISaltoConPatas IMiCaballo2 = miCaballo;
            //Console.WriteLine("Salta con " + IMiCaballo2.NumeroPatas() + " patas");

            AvisoTrafico av1 = new();
            av1.MostrarAviso();

            AvisoTrafico av2 = new("Jefatura Provincial Madrid", "Sanción de velocidad; 300€", "23-12-23");
            Console.WriteLine(av2.Fecha);
            av2.MostrarAviso();
        }
    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }
    interface IAnimalesYDeportes
    {
        string TipoDeporte();
        bool EsOlimpico();
    }
    interface ISaltoConPatas
    {
        int NumeroPatas();
    }
    class Mamifero(string nombre)
    {
        public string NombreSerVivo { get; set; } = nombre;

        public void Respirar() => Console.WriteLine("Soy capaz de respirar");

        public virtual void Pensar() => Console.WriteLine("Pensamiento instintivo básico");

        public void CuidarCrias() => Console.WriteLine("Cuido de mis crías");
    }
    class Ballena(string nombre) : Mamifero(nombre)
    {
        public void Nadar() => Console.WriteLine("Soy capaz de nadar");
    }
    class Caballo(string nombre) : Mamifero(nombre), IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        public string TipoDeporte()
        {
            return "Hípica";
        }

        public bool EsOlimpico()
        {
            throw new NotImplementedException();
        }

        public void Galopar() => Console.WriteLine("Soy capaz de galopar");
    }
    class Humano(string nombre) : Mamifero(nombre)
    {
        public override void Pensar() => Console.WriteLine("Soy capaz de pensar");
    }
    class Gorila(string nombre) : Mamifero(nombre), IMamiferosTerrestres
    {
        public int NumeroPatas()
        {
            return 2;
        }

        public override void Pensar() => Console.WriteLine("Pensamiento instintivo avanzado");

        public void Trepar() => Console.WriteLine("Soy capaz de trepar");
    }
}
