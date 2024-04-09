
int acumulador = 0;

//for (int i = 0; i < 10; i++)
//{
//    RealizarTarea(i);
//    Console.WriteLine($"Acumulador vale {acumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");
//}

Parallel.For(0, 100, RealizarTarea);


void RealizarTarea(int dato)
{

    Console.WriteLine($"Acumulador vale {acumulador}. Tarea realizada por el hilo {Thread.CurrentThread.ManagedThreadId}");

    if (acumulador % 2 == 0 )
    {
        acumulador += dato;
        Thread.Sleep(100);
    }
    else
    {
        acumulador -= dato;
        Thread.Sleep(100);

    }
}