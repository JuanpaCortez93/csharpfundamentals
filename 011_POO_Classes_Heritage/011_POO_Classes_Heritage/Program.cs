
Horses spirit = new Horses("Spirit");
Human ximenita = new Human("Ximenita");
Human pablito = new Human("Pablito");
Gorilla copito = new Gorilla("Copito");

//spirit.TakeCareChildren();
//copito.ClimbTrees();
//Console.WriteLine(ximenita.Equals(ximenita));
//Console.WriteLine(ximenita.Name);

Mammals[] mammals = new Mammals[4];

mammals[0] = spirit;
mammals[1] = copito;
mammals[2] = ximenita;
mammals[3] = pablito;

mammals[3].TakeCareChildren();

class Mammals
{

    public Mammals(string name) 
    {
        _name = name;
    }

    public void Breath() => Console.WriteLine("I can breath");
    public void TakeCareChildren() => Console.WriteLine("I take care of my children");

    public string Name { get { return _name; } }
    private string _name = "None";

}


class Horses : Mammals
{

    public Horses (string name) : base(name)
    {

    }

    public void Gallop ()
    {
        Console.WriteLine("As a horse, I can gallop");
    }

}

class Human : Mammals
{

    public Human (string name) : base(name)
    {

    }

    public void Think ()
    {
        Console.WriteLine("I can thinking");
    }
}

class Gorilla : Mammals
{

    public Gorilla (string name) : base(name)
    {

    }

    public void ClimbTrees ()
    {
        Console.WriteLine("I can climb trees");
    }
}