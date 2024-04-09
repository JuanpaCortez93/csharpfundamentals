//Bonus Antonio = Bonus.Medio;
//double bonusAntonio = (double)Antonio;

//double salarioFinal = bonusAntonio + 1500;
//Console.WriteLine(salarioFinal);


Employees juanpa = new Employees(Bonus.Medio, 1500);
Console.WriteLine($"Salario: {juanpa.Salary}");    

class Employees
{

    public Employees (Bonus bonus, double salary) {
        _salary = salary + (double)bonus;
    }

    public double Salary { get {return _salary; } }
    private double _salary;
}

public enum Bonus { Normal = 250, Medio = 300, Alto = 350, MuyAlto = 500 };