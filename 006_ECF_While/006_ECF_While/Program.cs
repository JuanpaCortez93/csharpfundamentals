Console.WriteLine("Deseas entrar en el bucle while? (SI/NO)");
string answer = Console.ReadLine();
bool continueProcess = false;

if (answer != null && answer.ToLower() == "si" ) continueProcess = true;

while (continueProcess)
{
    Console.WriteLine("Deseas terminar el bucle while? (SI/NO)");
    answer = Console.ReadLine();

    if (answer.ToLower() == "si") continueProcess = false; 
}

Console.WriteLine("Ha terminado el proceso");