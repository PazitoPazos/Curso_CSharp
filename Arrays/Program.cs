using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] edades = new int[4]; // Rellena con el valor por defecto del tipo
            //int[] edades = [19, 23, 36, 47];

            // Array implícito
            //var datos = new[] { "Juan", "Sara", "Manuel" };
            //var valores = new[] { 15, 23, 124, 43.3, 123.123 };

            // Array de objetos
            //Empleado[] arrayEmpleados = [new Empleado("Juan", 37), new Empleado("Sara", 21)];

            // Array de tipos o clases anónimas
            //var personas = new[]
            //{
            //    new {Nombre = "María", Edad = 32},
            //    new {Nombre = "Diana", Edad = 24},
            //    new {Nombre = "Luis", Edad = 27},
            //};

            //for (int i = 0; i < arrayEmpleados.Length; i++)
            //{
            //    Console.WriteLine(arrayEmpleados[i].Nombre);
            //}

            //foreach ( var per in personas )
            //{
            //    Console.WriteLine(per);
            //}

            //int[] numeros = [2, 43, 21, 123];
            //ProcesaDatos(numeros);

            //foreach (int dato in numeros)
            //{
            //    Console.WriteLine(dato);
            //}

            int[] arrayNumeros = LeerDatos();
            foreach (int i in arrayNumeros)
            {
                Console.WriteLine(i);
            }
        }

        static int[] LeerDatos()
        {
            Console.Write("¿Cuántos elementos tendrá el array?: ");
            string? respuesta = Console.ReadLine() ?? "0";
            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                do
                {
                    Console.Write($"Introduce el número para la posicion {i}: ");
                    respuesta = Console.ReadLine();
                } while (respuesta == null);

                datos[i] = int.Parse(respuesta);
            }

            return datos;
        }

        static void ProcesaDatos(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }
        }

        class Empleado(string nombre, int edad)
        {
            public string Nombre { get; set; } = nombre;
            public int Edad { get; set; } = edad;

        }
    }
}
