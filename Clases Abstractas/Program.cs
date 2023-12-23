namespace Clases_Abstractas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lagartija Juancho = new("Juancho");
            Juancho.GetNombre();

            Humano Juan = new("Juan");
            Juan.GetNombre();
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

    abstract class Animal
    {
        public void Respirar() => Console.WriteLine("Soy capaz de respirar");

        public abstract void GetNombre();
    }

    class Mamifero(string nombre) : Animal
    {
        public string? NombreSerVivo = nombre;

        public virtual void Pensar() => Console.WriteLine("Pensamiento instintivo básico");

        public void CuidarCrias() => Console.WriteLine("Cuido de mis crías");

        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del mamífero es: {NombreSerVivo}");
        }
    }

    class Lagartija(string nombre) : Animal
    {
        public string NombreReptil = nombre;

        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {NombreReptil}");
        }
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
