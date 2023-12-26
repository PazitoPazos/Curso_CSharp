namespace Delegados__Predicados_y_Lambdas
{
    internal class Program
    {
        delegate void ObjetoDelegado(string msj);
        delegate int OperacionesMatematicas(int num1, int num2);
        delegate bool ComparaPersonas(string n1, string n2);

        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }

        static bool ExisteJuan(Persona persona)
        {
            if (persona.Nombre == "Juan") return true;
            return false;
        }

        //static int Cuadrado(int num)
        //{
        //    return num * num;
        //}

        //static int Suma(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        static void Main(string[] args)
        {
            //ObjetoDelegado ElDelegado = new(MensajeBienvenida.SaludoBienvenida);
            //ElDelegado("Hola, acabo de llegar");
            //ElDelegado = new(MensajeDespedida.SaludoDespedida);
            //ElDelegado("Hola, ya me voy");

            //List<int> list = [.. new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }];
            //Predicate<int> ElPredicado = new(DamePares);
            //List<int> numPares = list.FindAll(ElPredicado);
            //Console.Write("Números pares: ");
            //foreach (int num in numPares)
            //{
            //    Console.Write(num + " ");
            //}

            //List<Persona> lista = [];
            //Persona P1 = new Persona();
            //P1.Nombre = "Juan";
            //P1.Edad = 18;
            //Persona P2 = new Persona();
            //P2.Nombre = "María";
            //P2.Edad = 28;
            //Persona P3 = new Persona();
            //P3.Nombre = "Ana";
            //P3.Edad = 37;
            //lista.AddRange([..new Persona[] { P1, P2, P3 }]);
            //Predicate<Persona> ElPredicado = new(ExisteJuan);
            //bool existe = lista.Exists(ElPredicado);
            //Console.WriteLine(existe ? "Hay una persona al menos que se llama Juan" : "Nadie se llama Juan");

            //OperacionesMatematicas operacion = new((num1, num2) => num1 + num2);
            //Console.WriteLine(operacion(4, 7));

            //List<int> nums = [.. new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }];
            //List<int> numPares = nums.FindAll(num => num % 2 == 0);
            //Console.Write("Números pares: ");
            //foreach (int num in numPares) Console.Write(num + " ");
            //nums.FindAll(num => num % 2 == 0)
            //    .ForEach(num => Console.Write(num + " "));

            Persona P1 = new();
            P1.Nombre = "Juan";
            P1.Edad = 18;
            Persona P2 = new();
            P2.Nombre = "María";
            P2.Edad = 18;

            ComparaPersonas comparaEdad = (pers1, pers2) => pers1 == pers2;
            Console.WriteLine(comparaEdad(P1.Nombre, P2.Nombre));
        }
    }
    class Persona
    {
        private string _nombre;
        private int _edad;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }

    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine("Mensaje de bienvenida: {0}", msj);
        }
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine("Mensaje de despedida: {0}", msj);
        }
    }
}
