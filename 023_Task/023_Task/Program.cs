//Task tarea = new Task(EjecutarTarea);
//Task tarea2 = new Task(() =>
//{
//    for (int j = 0; j < 10; j++)
//    {
//        var t = Thread.CurrentThread.ManagedThreadId;
//        Thread.Sleep(1000);
//        Console.WriteLine($"Esta vuelta de bucle corresponde al thread: {t} del hilo 2");
//    }
//});

//tarea.Start();
//tarea2.Start();

//Task tarea = Task.Run(() => {EjecutarTarea();});
//Task tarea2 = tarea.ContinueWith(EjecutarOtraTarea);


static void RealizarTresTareas()
{

    var tarea1 = Task.Run(() => EjecutarTarea());
    var tarea2 = Task.Run(() => EjecutarOtraTarea());
    //Task.WaitAll(tarea1, tarea2);
    Task.WaitAny(tarea1, tarea2);
    var tarea3 = Task.Run(() => EjecutarOtraTarea2());

}


RealizarTresTareas();
Console.ReadLine();

static void EjecutarTarea()
{
    for(int i = 0; i < 10; i++)
    {
        var t = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        Console.WriteLine($"Esta vuelta de bucle corresponde al thread: {t}");
    }
}

static void EjecutarOtraTarea()
{
    for (int i = 0; i < 10; i++)
    {
        var t = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(500);
        Console.WriteLine($"Esta vuelta de bucle corresponde al thread: {t} del hilo 2");
    }
}

static void EjecutarOtraTarea2()
{
    for (int i = 0; i < 10; i++)
    {
        var t = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(500);
        Console.WriteLine($"Esta vuelta de bucle corresponde al thread: {t} del hilo 3");
    }
}