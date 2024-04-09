//List<int> numbers = new List<int>();

//numbers.Add(10);
//numbers.Add(20);
//numbers.Add(30);
//numbers.Add(40);


//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//numbers.Remove(20);

//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

List<int> numberList = new List<int>(); 

Console.WriteLine("Cuantos elementos quieres introducir");
int itemsNumber = Convert.ToInt32(Console.ReadLine());  

for (int i = 0; i < itemsNumber; i++)
{
    Console.WriteLine($"Ingresa el item {i + 1}");
    int number = Convert.ToInt32(Console.ReadLine());
    numberList.Add(number);
}

Console.WriteLine("\n");
Console.WriteLine("Los números que has tomado son: ");

numberList.Sort();

foreach (var number in numberList)
{
    Console.WriteLine(number);
}