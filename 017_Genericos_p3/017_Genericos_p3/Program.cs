Store<Director> empleados = new Store<Director>(2);
Director director1 = new Director(1500);
Director director2 = new Director(2800);

//Store<Students> student1 = new Store<Students>(1);

interface IEmployess
{
    double GetSalary();
}

class Store <T> where T : IEmployess
{

    public Store (int z)
    {
        _employeesArray = new T[z];
    }

    public void AddEmployee (T obj)
    {
        _employeesArray[_index] = obj;
        _index++;   
    }

    public T GetEmployeeByIndex(int index) => _employeesArray[index];

    private int _index = 0;
    private T[] _employeesArray;
}

class Director : IEmployess
{
    public Director (double salary)
    {
        _salary = salary;
    }

    public double GetSalary() => _salary; 

    private double _salary;
}

class Secretary : IEmployess
{
    public Secretary(double salary)
    {
        _salary = salary;
    }
    public double GetSalary() => _salary; 
    private double _salary;
}

class Electricist : IEmployess
{
    public Electricist(double salary)
    {
        _salary = salary;
    }

    public double GetSalary() => _salary;

    private double _salary;
}

class Students
{

    public Students(double age)
    {
        _age = age; 
    }


    private double _age;
}