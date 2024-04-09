Queue<string> numbers = new Queue<string>();
numbers.Enqueue("one");
numbers.Enqueue("two");
numbers.Enqueue("three");
numbers.Enqueue("four");
numbers.Enqueue("five");

foreach(var number in numbers)
{
    Console.WriteLine(number);
}

numbers.Dequeue();
foreach (var number in numbers)
{
    Console.WriteLine(number);
}
