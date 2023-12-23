using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IAviso
    {
        void MostrarAviso();
        string Fecha { get; set; }
    }
}
