EmployeesAndCompanies example = new EmployeesAndCompanies();

example.getCEO();

class EmployeesAndCompanies
{

    public EmployeesAndCompanies() 
    {
        companyList = new List<Companies>();
        employeeList = new List<Employees>();

        companyList.Add(new Companies("Google"));
        companyList.Add(new Companies("NexTI"));

        employeeList.Add(new Employees("Felipe Cortez", 0, "RRHH Chief", 4000));
        employeeList.Add(new Employees("Juan Cortez", 1, "Jr Developer", 1000));
        employeeList.Add(new Employees("Pablo Cortez", 0, "CEO", 2000));
        employeeList.Add(new Employees("Byron Argoti", 0, "CEO", 2000));
        employeeList.Add(new Employees("Ximenita Mosquera", 1, "CEO", 2000));

    }

    public void getCEO()
    {
        IEnumerable<Employees> employees = from employee in employeeList join company in companyList on employee.CompanyId equals company.CompanyId where employee.Position == "CEO" && company.CompanyId == 1 orderby employee.EmployeeName select employee;
    
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.EmployeeName}");
        }

    }



    public List<Companies> companyList ;
    public List<Employees> employeeList;
}


class Companies
{

    public Companies(string companyName) { 
    
        _companyName = companyName;
        _companyId = _id;
        _id++;
    }

    public int CompanyId { get {return _companyId; } set {_companyId = value ; } }
    public string CompanyName { get {return _companyName; } set { _companyName = value; } }


    private static int _id = 0;
    private int _companyId;
    private string _companyName = "Company Name";

}

class Employees
{
    public Employees(string employeeName, int companyId, string position, double salary)
    {
        _employeeId = _idEmployee;
        _companyId = companyId;
        _employeeName = employeeName;
        _position = position;
        _salary = salary;

        _idEmployee++;
    }

    public int EmployeeId { get { return _employeeId; } set { _employeeId = value; } }
    public int CompanyId { get { return _companyId; } set { _companyId = value; } }
    public string EmployeeName { get { return _employeeName; } set { _employeeName = value; } }
    public string Position { get { return _position; } set {  _position = value; } }
    public double Salary { get { return _salary; } set { _salary = value; } }


    private static int _idEmployee = 0;
    private int _employeeId;
    private int _companyId;
    private string _employeeName = "Employee Name";
    private string _position = "CEO";
    private double _salary = 450.25;
}