Circles circle1 = new Circles();
//Console.WriteLine(circle1.CalcArea(1));

EurUsd conversorEURUSD = new EurUsd();

Console.WriteLine(conversorEURUSD.MoneyConverter(50));
Console.WriteLine(conversorEURUSD.Euro);
conversorEURUSD.Euro = 2;
Console.WriteLine(conversorEURUSD.MoneyConverter(50));


class Circles
{

    public double CalcArea(double ratio) => _PI * Math.Pow(ratio, 2);
    private const double _PI = Math.PI; 
}

class EurUsd
{

    public double MoneyConverter(double amount)
    {

        return amount * _euro;
    }
    public double Euro { get { return _euro ; } set { 
            if(value >= 0) { _euro = value; }
        } 
    }
    private double _euro = 1.253;

}