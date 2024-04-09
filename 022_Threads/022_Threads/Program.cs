Thread t1 = new Thread(GreetingMethod);
Thread t2 = new Thread(GreetingMethod);



t1.Start();
//t1.Join();

Console.WriteLine("Thread 1");
Thread.Sleep(1000);
Console.WriteLine("Thread 2");
Thread.Sleep(1000);
Console.WriteLine("Thread 3");
Thread.Sleep(1000);
Console.WriteLine("Thread 4");

t2.Start();
t2.Join();  



static void GreetingMethod()
{
    Console.WriteLine("Thread 1 - Hello");
    Thread.Sleep(1000);
    Console.WriteLine("Thread 2 - Hello");
    Thread.Sleep(1000);
    Console.WriteLine("Thread 3 - Hello");
    Thread.Sleep(1000);
    Console.WriteLine("Thread 4 - Hello");
}