using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class AvisoTrafico : IAviso
    {
        public string Remitente { get; set; }
        public string Mensaje { get; set; }
        public string Fecha { get; set; }

        public AvisoTrafico()
        {
            Remitente = "DGT";
            Mensaje = "Sanción cometida. Pague antes de 3 días y se beneficiará de una reducción en la sanción del 50%";
            Fecha = "";
        }

        public AvisoTrafico(string remitente, string mensaje, string fecha)
        {
            Remitente = remitente;
            Mensaje = mensaje;
            Fecha = fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje '{0}' ha sido enviado por {1} el día {2}", Mensaje, Remitente, Fecha);
        }
    }
}
