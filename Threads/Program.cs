namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Thread t = new Thread(MetodoSaludo);
            //t.Start();
            //t.Join();

            //Console.WriteLine("Thread 1");
            //Thread.Sleep(500);
            //Console.WriteLine("Thread 1");
            //Thread.Sleep(500);
            //Console.WriteLine("Thread 1");
            //Thread.Sleep(500);
            //Console.WriteLine("Thread 1");

            //Thread t2 = new Thread(MetodoSaludo);
            //t2.Start();
            //t2.Join();

            //CuentaBancaria cuentaFamilia = new CuentaBancaria(2000);
            //Thread[] hilosPersonas = new Thread[15];

            //for (int i = 0; i < hilosPersonas.Length; i++)
            //{
            //    Thread t = new Thread(cuentaFamilia.VamosRetirarEfectivo);
            //    t.Name = i.ToString();
            //    hilosPersonas[i] = t;
            //}

            //for (int i = 0;i < hilosPersonas.Length;i++)
            //{
            //    hilosPersonas[i].Start();

            //    // Sincroniza los threads
            //    hilosPersonas[i].Join();
            //}

            //var tareaTerminada = new TaskCompletionSource<bool>();

            //var hilo1 = new Thread(() =>
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("Hilo 1");
            //        Thread.Sleep(1000);
            //    }

            //    tareaTerminada.TrySetResult(true);
            //});

            //var hilo2 = new Thread(() =>
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("Hilo 2");
            //        Thread.Sleep(1000);
            //    }

            //    tareaTerminada.TrySetResult(true);
            //});

            //var hilo3 = new Thread(() =>
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("Hilo 3");
            //        Thread.Sleep(1000);
            //    }
            //});

            //hilo1.Start();
            //hilo2.Start();
            //var resultado = tareaTerminada.Task.Result;
            //hilo3.Start();

            for (int i = 0; i < 100; i++)
            {
                //Thread t = new Thread(EjecutarTarea);
                //t.Start();

                ThreadPool.QueueUserWorkItem(EjecutarTarea, i);
            }

            Console.ReadLine();
        }

        static void EjecutarTarea(Object o)
        {
            int nTarea = (int) o;
            Console.WriteLine($"Thread nº: {Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea nº {o}");
            Thread.Sleep(1000);
            Console.WriteLine($"Thread nº: {Thread.CurrentThread.ManagedThreadId} ha terminado la tarea nº {o}");
        }

        static void MetodoSaludo()
        {
            Console.WriteLine("Thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Thread 2");
        }
    }

    class CuentaBancaria
    {
        private Object bloqueaSaldoPositivo = new Object();

        double Saldo { get; set; }

        public CuentaBancaria(double saldo) 
        {
            Saldo = saldo;
        }

        public double RetirarEfectivo(double cantidad)
        {
            if ((Saldo - cantidad) < 0)
            {
                Console.WriteLine($"Lo siento queda {Saldo}€ en la cuenta. Hilo: {Thread.CurrentThread.Name}");
                return Saldo;
            }

            // Bloquea el proceso para el hilo actual
            //lock(bloqueaSaldoPositivo)
            //{
                if (Saldo >= cantidad)
                {
                    Console.WriteLine($"Retirado {cantidad}€ y queda {Saldo - cantidad}€ en la cuenta. Hilo: {Thread.CurrentThread.Name}");
                    Saldo -= cantidad;

                }

                return Saldo;
            //}
        }

        public void VamosRetirarEfectivo()
        {
            Console.WriteLine($"Está sacando dinero el hilo: {Thread.CurrentThread.Name}");
            for (int i = 0; i < 4; i++) RetirarEfectivo(500);
        }

    }
}
