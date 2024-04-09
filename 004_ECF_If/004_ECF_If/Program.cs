bool haceFrio = false;

if (haceFrio)
{
    Console.WriteLine("Efectivamente, hace frío");
}
else
{
    Console.WriteLine("No hace frío, ponte gorra que la radiación es alta");
}

Console.WriteLine("Ingresa tu edad");
int edad = Convert.ToInt32(Console.ReadLine());

if(edad < 18)
{
    Console.WriteLine("Prohibida la venta de licor a menores de edad");
}
else
{
    Console.WriteLine("Puedes comprar licor");
}

