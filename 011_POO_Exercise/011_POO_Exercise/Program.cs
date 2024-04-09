Transports[] transports = new Transports[3];

Boats kawasaki = new Boats("Kawasaki");
Vehicles kiaPicanto = new Vehicles("Kia Picanto");
Airplanes airbus320 = new Airplanes("AirBus 380");
airbus320.Engine = true;

transports[0] = kawasaki;
transports[1] = kiaPicanto;
transports[2] = airbus320;

foreach (var transport in transports)
{
    Console.WriteLine($"{transport.Name}. Engine status: {transport.Engine}");
    transport.Drive();
    Console.WriteLine("\n");
}


class Transports
{

    public Transports(string name) 
    {
        _name = name;
    }

    public virtual void Drive() => Console.WriteLine("I am driving a vehicle");
    
    public string Name { get {return _name ;} }  
    public bool Engine { get {return _engine;} set { _engine = value; } }

    private string _name = String.Empty;
    private bool _engine = false;

}


class Airplanes : Transports
{
    public Airplanes (string name) : base(name)
    {

    }

    public override void Drive() => Console.WriteLine("I am flying an airplane");

}

class Vehicles : Transports
{
    public Vehicles (string name) : base(name)
    {

    }

    public override void Drive() => Console.WriteLine("I am driving a car");

}

class Boats : Transports
{
    public Boats (string name) : base(name)
    {

    }

    public override void Drive() => Console.WriteLine("I am sailing a boat");
}