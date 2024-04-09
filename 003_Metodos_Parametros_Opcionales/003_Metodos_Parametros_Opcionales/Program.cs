//GENERAR METODOS Y LA AYUDA DE VS

//GENERAR MÉTODOS
int valor1 = 7;
double valor2 = 8.1;
double valor3 = 8.3;
Console.WriteLine(Suma(4, 3));

//LAMBDA
int Suma(int v1, int v2) => v1 + v2;

//PARAMETROS OPCIONALES
static double SumaTresNumeros(int num1, double num2, double num3 = 1) => num1 + num2 + num3;

Console.WriteLine(SumaTresNumeros(4, 3));