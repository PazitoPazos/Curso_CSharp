namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool haceFrio = true;
            //Console.WriteLine(!haceFrio);

            //int edad = int.Parse(Console.ReadLine());
            //if (edad >= 18)
            //{
            //    Console.WriteLine("Eres mayor de edad");
            //} else
            //{
            //    Console.WriteLine("No eres mayor de edad");
            //}

            //bool carnet = true;
            //if (edad >= 18 && carnet) Console.WriteLine("Puedes conducir");ç

            Console.WriteLine("Elige medio de transporte (coche, tren, avión):");
            string medioTransporte = Console.ReadLine();
            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad media: 100km/h");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad media: 250km/h");
                    break;
                case "avión":
                    Console.WriteLine("Velocidad media: 800km/h");
                    break;
                default: 
                    Console.WriteLine($"Velocidad media del transporte {medioTransporte} desconocida."); 
                    break;
            }
        }
    }
}
