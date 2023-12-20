//Console.WriteLine("Hello, World!");

// Declaración e inicialización de una variable
//int edad;
//edad = 22;
//Console.WriteLine(edad);

// Operaciones con datos numéricos
//Console.WriteLine(5 / 2);
//Console.WriteLine(5.0 / 2.0);

// Incrementar/Decrementar antes o después de una acción
//Console.WriteLine("Tienes una edad de " + edad++ + " años");
//edad = 22;
//Console.WriteLine($"Tienes una edad de {--edad} años");

// Declaración de múltiples variables
//int edadPersona1;
//int edadPersona2;
//int edadPersona3;
//int edadPersona4;
//edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;
//Console.WriteLine(edadPersona2);

//int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 27;
//Console.WriteLine(edadPersona4);

// Conversión explícita (Casting)
//double temperatura = 27.8;
//int temperatura2 = (int) temperatura;

// Conversión implícita
//float temperatura = 27.8f;
//double temperatura2 = temperatura;

// Parsear valores
//Console.WriteLine("Introduce el primer número:");
//int inp = int.Parse(Console.ReadLine());
//Console.WriteLine(inp.GetType());

// Constantes
//const int VALOR = 5;
//const int VALOR2 = 6;
//Console.WriteLine("El valor de la constante es: {0}", VALOR);

const double PI = 3.1416;
Console.WriteLine("Introduce la medida del radio:");
double radio = double.Parse(Console.ReadLine());
double area = Math.Pow(radio, 2) * PI;
Console.WriteLine($"El área del círculo es {area}");