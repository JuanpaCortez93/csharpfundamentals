// Stack: LIFO Last In - First Out


Stack<int> stack = new Stack<int>();

stack.Push(0);
stack.Push(1);
stack.Push(2);

foreach (var item in stack)
{
    Console.WriteLine(item);
}

stack.Pop();
Console.WriteLine("\n");

foreach (var item in stack)
{
    Console.WriteLine(item);
}