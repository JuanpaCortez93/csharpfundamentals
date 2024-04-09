Employees ximenita = new Employees("Ximena Mosquera", 64, "spacio@hotmail.com");
Employees pablito = new Employees("Pablo Cortez", 64, "pcaa@hotmail.com");

Console.WriteLine(ximenita.UserId);
Console.WriteLine(pablito.UserId);



class Employees
{

    public Employees (string name, int age, string email) 
    {
        _userId = _id;
        _name = name;
        _age = age;
        _email = email;
        _id++;       
    }

    public int UserId { get { return _userId; } }

    private static int _id = 1;
    private int _userId;
    private string _name;
    private int _age;
    private string _email;
}