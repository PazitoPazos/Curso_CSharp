namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* LISTS */
            //List<int> numeros = [];
            //Console.WriteLine("Introduce elementos (0 para salir):");
            //int elem = -1;
            //while ((elem = int.Parse(Console.ReadLine())) != 0)
            //{
            //    numeros.Add(elem);
            //}
            //numeros.RemoveAt(numeros.Count - 1);
            //Console.Write("Elementos introducidos: ");
            //foreach (int i in numeros)
            //{
            //    Console.Write(i + " ");
            //}

            /* LINKED LISTS */
            //LinkedList<int> numeros = new();
            //foreach (int numero in new int[] { 10, 8, 6, 4, 2, 0 })
            //{
            //    numeros.AddLast(numero);
            //}
            ////numeros.Remove(6);
            //LinkedListNode<int> nodoImportante = new(15);
            //numeros.AddFirst(nodoImportante);
            ////foreach (int numero in numeros)
            ////{
            ////    Console.WriteLine(numero);
            ////}
            //for (LinkedListNode<int>? nodo = numeros.First; nodo != null; nodo = nodo.Next)
            //{
            //    int numero = nodo.Value;
            //    Console.WriteLine(numero);
            //}

            /* QUEUE */
            //Queue<int> numeros = new();
            //foreach (int num in new int[] { 2, 4, 6, 8, 10 })
            //{
            //    numeros.Enqueue(num);
            //}
            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}
            //numeros.Dequeue();
            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}

            /* STACK */
            //Stack<int> numeros = new();
            //foreach (int num in new int[] { 2, 4, 6, 8, 10 })
            //{
            //    numeros.Push(num);
            //}

            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}

            //numeros.Pop();
            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}

            /* DICTIONARY */
            Dictionary<string, int> edades = [];
            edades.Add("Juan", 18);
            edades.Add("Diandra", 35);
            edades["María"] = 25;
            edades["Antonio"] = 29;

            foreach (KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine($"Nombre: {persona.Key}, Edad: {persona.Value}");
            }
        }
    }
}
