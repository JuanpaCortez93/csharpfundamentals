//int numero = int.MaxValue;
//numero = checked(numero + 20);
//Console.WriteLine(numero);


Console.WriteLine("Escribe un mes");

try
{
    int monthNumber = Convert.ToInt32(Console.ReadLine());
    MonthNameUsingNumber(monthNumber);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

string MonthNameUsingNumber (int month)
{
    switch (month)
    {
        case 1:
            return "Enero";

        case 2:
            return "Febrero";

        case 3:
            return "Marzo";

        case 4:
            return "Abril";

        case 5:
            return "Mayo";

        case 6:
            return "Junio";

        case 7:
            return "Julio";

        case 8:
            return "Agosto";

        case 9:
            return "Septiembre";

        case 10:
            return "Octubre";

        case 11:
            return "Noviembre";

        case 12:
            return "Diciembre";

        default:
            throw new Exception("This month does not exist"); 
    }
}
