namespace Delegados_Predicados_y_Lambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjetoDelegado ElDelegado = new(MensajeBienvenida.SaludoBienvenida);
            ElDelegado("Hola, acabo de llegar");

            ElDelegado = new(MensajeDespedida.SaludoDespedida);
            ElDelegado("Hola, ya me voy");
        }

        delegate void ObjetoDelegado(string msj);
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
