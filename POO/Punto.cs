using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Punto
    {
        private int x, y;
        private static int contadorDeObjetos = 0;
        public const int constantePrueba = 7;

        public Punto() {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }
        public Punto(int x, int y) {
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;
        }

        public static int ContadorDeObjetos() => contadorDeObjetos;
    }
}
