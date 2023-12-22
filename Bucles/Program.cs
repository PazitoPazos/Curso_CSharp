namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);

            int respuesta = -1;

            while (respuesta != numeroAleatorio)
            {
                Console.Write("Adivina el número entre 0 y 100:");
                respuesta = int.Parse(Console.ReadLine());

                if (respuesta < numeroAleatorio)
                {
                    Console.WriteLine("El número aleatorio es mayor");
                }
                else if (respuesta > numeroAleatorio)
                {
                    Console.WriteLine("El número aleatorio es menor");
                }
            }

            Console.WriteLine("¡Acertaste!");


            //string? respuesta;
            //do {
            //    Console.WriteLine("¿Cuál es tu nombre?");
            //    respuesta = Console.ReadLine();
            //} while (respuesta == "" || respuesta == null);
        }
    }
}
