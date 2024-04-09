SaveObjects<string> valores = new SaveObjects<string>(2);

valores.AddElement("Juan");
valores.AddElement("Ana");

Console.WriteLine(valores.GetElemetFromArray(1));


SaveObjects<Employees> employees = new SaveObjects<Employees>(2);
Employees felipe = new Employees(1500);
Employees pablo = new Employees(2000);

employees.AddElement(felipe);
employees.AddElement(pablo);

Console.WriteLine(employees.GetElemetFromArray(1).Salary);

class SaveObjects<T>
{

    public SaveObjects(int z)
    {
        dataArray = new T[z];
    }

    public void AddElement(T obj)
    {
        dataArray[i] = obj;
        i++;
    }

    public T GetElemetFromArray(int i)
    {
        return dataArray[i];
    }

    private T[] dataArray;
    private int i = 0;

}


class Employees
{

    public Employees(double salary)
    {
        _salary = salary;
    }

    public double Salary { get { return _salary; } }
    private double _salary;
}
