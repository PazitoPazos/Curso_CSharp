using System;
namespace Metodos;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Suma(4, 2.32));
    }


    // Definiendo funciones
    //static void MensajeEnPantalla(string mensaje)
    //{
    //    Console.WriteLine(mensaje);
    //}

    //static int Sumar(int num1, int num2)
    //{
    //    return num1 + num2;
    //}

    //MensajeEnPantalla("La suma de los números es: " + Sumar(1, 2).ToString());

    // Función estándar
    //static double Dividir(double num1, double num2)
    //{
    //    return num1 / num2;
    //}

    // Función Lambda
    //static double Dividir(double num1, double num2) => num1 / num2;
    //Func<double, double, double> Dividir = (num1, num2) => num1 / num2;

    //MensajeEnPantalla("La división de los números es: " + Dividir(3.32, 2.12).ToString());

    // Sobrecarga de métodos
    //static int Suma(int operador1, int operador2) => operador1 + operador2;
    //static double Suma(double operador1, double operador2) => operador1 + operador2;

    // Parámetros opcionales
    private static double Suma(int v1, double v2, double v3 = 0) => v1 + v2 + v3;
}