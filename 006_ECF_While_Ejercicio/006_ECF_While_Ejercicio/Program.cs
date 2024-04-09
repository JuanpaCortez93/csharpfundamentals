﻿Random number = new Random();
int randomNumber = number.Next(0, 100); 
int myNumber;

Console.WriteLine("Please, enter a number between 1 and 100");
myNumber = Convert.ToInt32(Console.ReadLine());

while(myNumber < 1 && myNumber > 100)
{
    Console.WriteLine("This number is not correct\nPlease, enter a number between 1 and 100");
    myNumber = Convert.ToInt32(Console.ReadLine());
}

while(myNumber != randomNumber)
{
    if(myNumber < randomNumber) Console.WriteLine("The number is less than the random number");
    if(myNumber > randomNumber) Console.WriteLine("The number is greater than the random number");

    Console.WriteLine("This number is not correct\nPlease, enter a number between 1 and 100");
    myNumber = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"You got it! The number {randomNumber} is the correct!");