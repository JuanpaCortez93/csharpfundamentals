Console.WriteLine("Ingresa tu edad");
int edad = Convert.ToInt32(Console.ReadLine());

if (edad >= 18 && edad <= 75)
{

    Console.WriteLine("Tienes carnet de conducir?\n1.Yes/No");

    int carnet = Convert.ToInt32(Console.ReadLine());
    bool carnetCondicion = false;

    if (carnet == 1) carnetCondicion = true;

    if (carnetCondicion)
    {
        Console.WriteLine("Puedes conducir");
    }
    else
    {
        Console.WriteLine("No puedes conducir porque no tienes licencia");
    }

}
else
{
    Console.WriteLine("Tu edad está fuera del rango de conducción en Ecuador (de 18 a 75 años)");
}

