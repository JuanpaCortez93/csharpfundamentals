// AMBITO

int number1 = 5;
int number2 = 6;

void PrimerMetodo ()
{

    Console.WriteLine(number1 + number2);
}

void SegundoMetodo ()
{
    PrimerMetodo();
    Console.WriteLine(number1);
}

PrimerMetodo();
SegundoMetodo();

// SOBRECARGA

static int SumaNumeros(int operador1, int operador2) => operador1 + operador2;
//static double SumaNumeros(double operador1, double operador2) => operador1 + operador2;

SumaNumeros(1, 2);