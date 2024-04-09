
for(int i = 0; i < 10; i++)
{
    //Thread t = new Thread(EjecutarTarea);
    //t.Start();

    ThreadPool.QueueUserWorkItem(EjecutarTarea, i);

}

Console.ReadLine();


static void EjecutarTarea(Object obj)
{

    int nTarea = (int)obj;

    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} started its task. Task number {nTarea}");
    Thread.Sleep( 1000 );
    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} finished its task. Task number {nTarea}");
}