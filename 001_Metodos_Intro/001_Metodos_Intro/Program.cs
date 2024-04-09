void MensajePantalla ()
{
    Console.WriteLine("Mensaje en pantalla");
}

static int SumaDosNumeros (int num1, int num2)
{
    return (num1 + num2);
}

static double DivideDosNumeros (double num1, double num2) => num1 / num2;

MensajePantalla();
Console.WriteLine(SumaDosNumeros(1, 2));
Console.WriteLine(DivideDosNumeros(1,2));