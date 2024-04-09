

LinkedList<int> numbers = new LinkedList<int>();
numbers.AddLast(12);
numbers.AddLast(34); 
numbers.AddLast(22);
numbers.AddLast(22);
numbers.AddLast(20);

foreach(var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n");

numbers.AddFirst(40);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n");
numbers.Remove(22);
foreach (var number in numbers)
{
    Console.WriteLine(number);
}
