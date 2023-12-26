namespace Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new();
            miArchivo.Mensaje();
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;
        int contador = 0;
        string? linea;

        public ManejoArchivos()
        {
            archivo = new(@"E:\Pazos\Documents\Web Developing\dotnet-repos\PrimeraAplicacion\Destructor\texto.txt");

            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        public void Mensaje()
        {
            Console.WriteLine("El archivo tiene {0} líneas", contador);
        }

        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
