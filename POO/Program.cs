namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circulo c1 = new Circulo();
            //Console.WriteLine(c1.CalcularArea(5));

            //ConversorEuroDolar conv = new ConversorEuroDolar();
            //conv.setEuro(-1.45);
            //Console.WriteLine(conv.ConvertirADolar(50));

            //Coche coche1 = new Coche();
            //Console.WriteLine(coche1.InfoCoche);

            //Coche coche2 = new Coche(3);
            //Console.WriteLine(coche2.InfoCoche);

            //Coche coche3 = new Coche(2, 1200, 100);
            //Console.WriteLine(coche3.InfoCoche);

            //realizarTarea();

            var miVariable = new { Nombre = "Juan", Edad = 19 };
            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

            var miVariable2 = new { Nombre = "Ana", Edad = 25 };
            Console.WriteLine(miVariable2.Nombre + " " + miVariable2.Edad);

            miVariable = miVariable2;
            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);
        }

        static void realizarTarea()
        {
            // TODO: Acabar este método
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los puntos es: {distancia}");
            Console.WriteLine($"El número de puntos creados es: {Punto.ContadorDeObjetos()}");
            Console.WriteLine($"El valor de la constante de clase es: {Punto.constantePrueba}");
        }
    }

    class Circulo
    {
        private const double PI = 3.1416;

        public double CalcularArea(int radio)
        {
            return PI * radio * radio;
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;
        
        public double ConvertirADolar(double cantidad)
        {
            return cantidad * euro;
        }

        public void setEuro(double nuevoValor)
        {
            if (nuevoValor >= 0) euro = nuevoValor;
        }
    }

    partial class Coche
    {
        public Coche()
        {
            Ruedas = 4;
            Largo = 2000;
            Ancho = 200;
            Climatizador = false;
            Tapiceria = "Tela";
        }

        public Coche(int ruedas)
        {
            Ruedas = ruedas;
            Largo = 2000;
            Ancho = 200;
            Climatizador = false;
            Tapiceria = "Tela";
        }

        public Coche(int ruedas, int largo, int ancho)
        {
            Ruedas = ruedas;
            Largo = largo;
            Ancho = ancho;
            Climatizador = false;
            Tapiceria = "Tela";
        }
    }

    partial class Coche
    {
        public int Ruedas { get; set; }
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public bool Climatizador { get; set; }
        public string Tapiceria { get; set; }

        public string InfoCoche
        {
            get
            {
                return $"La información del coche es:\nRuedas: {Ruedas}\nLargo: {Largo}\nAncho: {Ancho}\nClimatizador: {(Climatizador ? "Sí" : "No")}\nTapiceria: {Tapiceria}\n";
            }
        }
    }
}
