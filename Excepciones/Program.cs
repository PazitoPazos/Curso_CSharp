namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random numero = new Random();
            //int numeroAleatorio = numero.Next(0, 101);

            //int respuesta = -1;
            //int intentos = 0;

            //do
            //{
            //    Console.Write("Adivina el número entre 0 y 100: ");

            //    try
            //    {
            //        respuesta = int.Parse(Console.ReadLine());
            //    }
            //    catch (OverflowException e)
            //    {
            //        Console.WriteLine("El valor introducido está fuera del rango Int32");
            //        continue;
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("No has introducido un número");
            //        continue;
            //    }
            //    catch (Exception e) // when (e.GetType() != typeof(FormatException) && e.GetType() != typeof(OverflowException))
            //    {
            //        Console.WriteLine(e);
            //        //Console.WriteLine(e.Message);
            //        continue;
            //    }
            //    //catch (OverflowException e)
            //    //{
            //    //    Console.WriteLine("El valor introducido está fuera del rango Int32");
            //    //    continue;
            //    //}
            //    //catch (FormatException e)
            //    //{
            //    //    Console.WriteLine("No has introducido un número");
            //    //    continue;
            //    //}

            //    if (respuesta < numeroAleatorio)
            //    {
            //        Console.WriteLine("El número aleatorio es mayor");
            //    }
            //    else if (respuesta > numeroAleatorio)
            //    {
            //        Console.WriteLine("El número aleatorio es menor");
            //    }
            //    intentos++;
            //} while (respuesta != numeroAleatorio);

            //Console.WriteLine($"¡Acertaste al intento {intentos}!");

            // Sólo para int y Long
            //checked
            //{
            //int num = int.MaxValue;
            //int resultado = checked(num + 1);
            //Console.WriteLine(resultado);
            //}

            //Console.Write("Introduce el número del mes: ");
            //int numeroMes = int.Parse(Console.ReadLine());
            //Console.WriteLine(NombreDelMes(numeroMes));

            System.IO.StreamReader archivo = null;

            try
            {
                string? linea;
                int contador = 0;
                string path = @"E:\Pazos\Documents\Web Developing\dotnet-repos\PrimeraAplicacion\Excepciones\prueba.txt";
                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }

                Console.WriteLine(contador);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                if (archivo != null)
                {
                    Console.WriteLine("Cerrando fichero...");
                    archivo.Close();
                }
            }
        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
