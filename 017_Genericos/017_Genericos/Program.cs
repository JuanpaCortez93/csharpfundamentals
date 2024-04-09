ObjectsSave archivos = new ObjectsSave(4);

archivos.Add("Ximena");
archivos.Add("Juan");
archivos.Add("Pablo");
archivos.Add("Felipe");

Console.WriteLine(archivos.GetElemento(2));

ObjectsSave empleados = new ObjectsSave(2);
Employees juan = new Employees(450);
Employees diana = new Employees(450);

empleados.Add(juan);
empleados.Add(diana);

var empleado = empleados.GetElemento(1);


class ObjectsSave
{
    public ObjectsSave(int z) { 
    
        _elementObject = new Object[z];
        
    }

    public void Add (Object obj)
    {
        _elementObject[_i] = obj;
        _i++;
    }

    public Object GetElemento(int i) => _elementObject[i];


    private Object[] _elementObject;
    private int _i = 0;
}

class Employees
{

    public Employees (double salary)
    {
        _salary = salary;
    }

    public double Salary { get { return _salary; } }
    private double _salary;
}