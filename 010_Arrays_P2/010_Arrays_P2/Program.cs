// Arrays implícitos

var data = new[] { "Juan", "Díaz", "España" };
var juan = new[] { "Juan", "Cortez", "Ecuador" };

var valores = new[] { 13, 28, 13.3, 14.9 }; //TODOS LOS DATOS SON TIPO DOUBLE!

// Array de objetos

Employees[] empleados = new Employees[3];

empleados[0] = new Employees("Juan", 30, 500);
empleados[1] = new Employees("Carlos", 30, 400);
empleados[2] = new Employees("Carlita", 30, 600);

for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine($"Employee's name is {empleados[i].Name}");
}

foreach (var employee in empleados)
{
    Console.WriteLine($"Employee's name is {employee.Name}");
}

class Employees
{
    public Employees (string name, int age, double salary)
    {
        _userId = _id;
        _name = name;
        _age = age;
        _salary = salary;
        _id++;
    }

    public int UserId { get { return _userId; } }
    public string Name { get { return _name; } set { _name = value; } }
    public int Age { get { return _age; } set { _age = value; } }
    public double Salary { get { return _salary; } set { _salary = value; } }

    private static int _id = 0;
    private int _userId;
    private string _name;
    private int _age;
    private double _salary;
}