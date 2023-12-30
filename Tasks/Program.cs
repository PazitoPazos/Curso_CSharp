namespace Tasks
{
    internal class Program
    {
        private static int acumulador = 0;

        static void Main(string[] args)
        {
            //Task tarea = new Task(EjecutarTarea);
            //tarea.Start();
            //Task tarea2 = new Task(() =>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        var miThread = Thread.CurrentThread.ManagedThreadId;
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Tarea correspondiente al Thread: {miThread}");
            //    }
            //});
            //tarea2.Start();

            //Task tarea = Task.Run(EjecutarTarea);
            //Task tarea2 = tarea.ContinueWith(EjecutarOtraTarea);
            //Task tarea2 = tarea.ContinueWith(t => { EjecutarOtraTarea(); });

            //RealizarTodasTareas();

            //for (int i = 0; i < 100; i++)
            //{
            //    RealizarTarea(i);
            //    Console.WriteLine($"Acumulador: {acumulador}. Tarea realizada por el Thread: {Thread.CurrentThread.ManagedThreadId}");
            //}

            //Parallel.For(0, 100, dato =>
            //{
            //    Console.WriteLine($"Acumulador: {acumulador}. Tarea realizada por el Thread: {Thread.CurrentThread.ManagedThreadId}");
            //    if (acumulador % 2 == 0)
            //    {
            //        acumulador += dato;
            //        Thread.Sleep(100);
            //    }
            //    else
            //    {
            //        acumulador -= dato;
            //        Thread.Sleep(100);
            //    }
            //});

            CancellationTokenSource miToken = new CancellationTokenSource();
            CancellationToken cancelaToken = miToken.Token;

            Task tarea = Task.Run(() => RealizarTarea(cancelaToken));

            for (int i = 0; i < 100; i++)
            {
                acumulador += 30;
                Thread.Sleep(1000);

                if (acumulador > 100)
                {
                    miToken.Cancel();
                    break;
                }
            }

            Thread.Sleep(1000);

            Console.WriteLine($"Valor final de acumulador: {acumulador}");

            Console.ReadLine();
        }

        static void RealizarTarea(CancellationToken token)
        {
            for (int i = 0; i < 100; i++)
            {
                acumulador++;
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine($"Acumulador: {acumulador}. Tarea realizada por el Thread: {miThread}");

                if (token.IsCancellationRequested)
                {
                    acumulador = 0;
                    return;
                }
            }
        }

        static void RealizarTodasTareas()
        {
            var tarea1 = Task.Run(EjecutarTarea);

            tarea1.Wait();

            var tarea2 = Task.Run(EjecutarTarea2);

            //Task.WaitAll(tarea1, tarea2);
            //Task.WaitAny(tarea1, tarea2);

            var tarea3 = Task.Run(EjecutarTarea3);
        }

        static void EjecutarTarea()
        {
            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine($"Tarea 1: Esta vuelta de bucle corresponde al Thread: {miThread}");
            }
        }

        static void EjecutarTarea2()
        {
            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine($"Tarea 2: Esta vuelta de bucle corresponde al Thread: {miThread}");
            }
        }

        static void EjecutarTarea3()
        {
            for (int i = 0; i < 5; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine($"Tarea 3: Esta vuelta de bucle corresponde al Thread: {miThread}");
            }
        }
    }
}
