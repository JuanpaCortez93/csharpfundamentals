
int[] enteros =  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = new List<int>();

Console.WriteLine("Forma tradicional");

foreach (int i in enteros)
{
    if(i % 2 == 0)
    {
        numerosPares.Add(i);
    }
}

foreach(var numeroPar in numerosPares)
{
    Console.WriteLine(numeroPar);
}

Console.WriteLine("\nCon LINQ");

IEnumerable<int> numerosParesConIEnumerable = from numero in enteros where numero % 2 == 0 select numero;
foreach(var numeroPar in numerosParesConIEnumerable)
{
    Console.WriteLine(numeroPar);
}