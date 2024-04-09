

Empleados empleado = new Empleados(475, 20);
empleado.SalarioFinal();
Console.WriteLine(empleado.SalarioBase);



public struct Empleados
{
    public double salarioBase, comision;

    public Empleados (double salarioBase, double comision)
    {
        this.salarioBase = salarioBase;
        this.comision = comision;
    }

    public double SalarioBase { get { return salarioBase; } set { salarioBase = value; } }
    public double Comision { get { return comision; } set { comision = value; } }

    public void SalarioFinal ()
    {
        salarioBase += comision;
    }
}