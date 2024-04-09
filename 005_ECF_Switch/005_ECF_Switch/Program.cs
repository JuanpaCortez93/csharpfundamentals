Console.WriteLine("Elige un medio de transporte: Coche, Tren o Avion");
string option = Console.ReadLine();

switch(option.ToUpper())
{
    case "COCHE":
        Console.WriteLine("Estas conduciendo un COCHE");
        break;

    case "TREN":
        Console.WriteLine("Estas viajando en un TREN");
        break;

    case "AVION":
        Console.WriteLine("Estas viajando en un AVIÓN");
        break;

    default:
        Console.WriteLine("Opcion no válida");
        break;
}