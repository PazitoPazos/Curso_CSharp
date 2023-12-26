using System.Text.RegularExpressions;

namespace Expresiones_Regulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string frase = "Mi nombre es Juan y mi nº de tlfno es (+34)123-456-789 y mi código postal es 29679";
            //string patron = @"\+34";
            //Regex miRegex = new(patron);
            //MatchCollection elMatch = miRegex.Matches(frase);
            //Console.WriteLine(elMatch.Count > 0 ? "Se ha encontrado número de tlf de España" : "No se encontrado número de tlf de España");

            string frase = "Mi web es https://pildorasinformaticas.es";
            string patron = "https?://(www.)?pildorasinformaticas.es";
            Regex miRegex = new(patron);
            MatchCollection elMatch = miRegex.Matches(frase);
            Console.WriteLine(elMatch.Count > 0 ? "Se ha encontrado web" : "No se encontrado web");
        }
    }
}
