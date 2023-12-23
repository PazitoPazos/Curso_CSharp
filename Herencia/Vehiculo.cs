using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Vehiculo
    {
        public void Arrancar(string sonidoAlArrancar)
        {
            Console.WriteLine($"Arrancando el motor: {sonidoAlArrancar}");
        }

        public void Parar(string sonidoAlParar)
        {
            Console.WriteLine($"Parando el motor: {sonidoAlParar}");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Método general para conducir");
        }
    }
}
