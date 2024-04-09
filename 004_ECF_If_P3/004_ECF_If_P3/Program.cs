double nota1;
double nota2;
double nota3;
double average;

Console.WriteLine("Ingresa la nota 1");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa la nota 2");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa la nota 3");
nota3 = Convert.ToDouble(Console.ReadLine());

average = (nota1 + nota2 + nota3)/3;

if(average < 9) Console.WriteLine("Te has quedado en esta materia");
else if (average >=9 && average < 14) Console.WriteLine("Darás supletorio");
else Console.WriteLine("Has pasado el semestre");
