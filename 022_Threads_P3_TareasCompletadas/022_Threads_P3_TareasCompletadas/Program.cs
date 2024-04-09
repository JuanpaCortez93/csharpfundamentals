var tareaTerminada = new TaskCompletionSource<bool>();


var thread1 = new Thread(() =>
{
    for(int i = 0; i < 4; i++)
    {
        Console.WriteLine("Hilo 1");
        Thread.Sleep(1000);
    } 

    tareaTerminada.TrySetResult(true);
});

var thread2 = new Thread(() =>
{
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Hilo 2");
        Thread.Sleep(1000);
    }
});

var thread3 = new Thread(() =>
{
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Hilo 3");
        Thread.Sleep(1000);
    }

    tareaTerminada.TrySetResult(true);
});

thread1.Start();
thread2.Start();
var resultado = tareaTerminada.Task.Result;
thread3.Start();