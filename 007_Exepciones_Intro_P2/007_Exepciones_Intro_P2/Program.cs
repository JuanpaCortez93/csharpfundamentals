
//Console.WriteLine("Enter a number");

//try
//{
//    int number = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"Your number is {number}");
//}
//catch (FormatException)
//{
//    Console.WriteLine("This is not a number");
//}
//catch (Exception e) when (e.GetType() != typeof(FormatException))
//{
//    Console.WriteLine(e.Message);
//}    


int temp;

checked
{
    temp = int.MaxValue;
    temp += 20;

    Console.WriteLine(temp);
}