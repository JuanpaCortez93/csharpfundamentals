Cars aveo = new Cars(1.80, 1.1);
Cars picanto = new Cars(2.1, 1.2);

// WHEELS
Console.WriteLine(aveo.Wheels);
Console.WriteLine(picanto.Wheels);

// WIDTH
Console.WriteLine(aveo.Width);
Console.WriteLine(picanto.Width);

// HEIGHT
Console.WriteLine(aveo.Height);
Console.WriteLine(picanto.Height);

// AIR CONDITIONER
Console.WriteLine(aveo.AirConditioner);
picanto.AirConditioner = true;
Console.WriteLine(picanto.AirConditioner);

// UPHOLSTERY
Console.WriteLine(aveo.GetUpholstery());
picanto.SetUpholstery("Leather");
Console.WriteLine(picanto.GetUpholstery());

partial class Cars
{

    public Cars(double height, double width)
    {
        _height = height;
        _width = width;
    }

    public int Wheels { get { return _wheels; } }
    public double Height { get { return _height; } }
    public double Width { get { return _width; } }

    public bool AirConditioner { get { return _airConditioner; } set { _airConditioner = value; } }

    public string GetUpholstery()
    {
        return _upholstery;
    }

    public void SetUpholstery(string upholstery)
    {
        _upholstery = upholstery;
    }
}

partial class Cars { 

    private const int _wheels = 4;
    private double _height;
    private double _width;
    private bool _airConditioner;
    private string _upholstery = "None";
}