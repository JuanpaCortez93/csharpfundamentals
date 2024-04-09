Mammals[] mammals = new Mammals[3];

Horses spirit = new Horses("Spirit");
Human ximenita = new Human("Ximenita");
Gorilla copito = new Gorilla("Copito");

mammals[0] = spirit;
mammals[1] = copito;
mammals[2] = ximenita;

foreach (var mammal in mammals)
{
    mammal.Think();
}



interface ITerrestialMammals
{
    int NumberExtremitiesForMovement();
}

interface ISportsMammals
{
    string SportType();
    bool IsOlimpic();
}

interface IJump
{
    int NumberOfLegsToJump();
}

class Mammals
{

    public Mammals(string name)
    {
        _name = name;
    }

    public void Breath() => Console.WriteLine("I can breath");
    public void TakeCareChildren() => Console.WriteLine("I take care of my children");
    public virtual void Think() => Console.WriteLine("Basic thinking");

    public string Name { get { return _name; } }
    private string _name = "None";

}


class Horses : Mammals, ITerrestialMammals, ISportsMammals, IJump
{

    public Horses(string name) : base(name)
    {

    }
    public void Gallop() => Console.WriteLine("As a horse, I can gallop");
    public int NumberExtremitiesForMovement() => 4;
    public string SportType() => "Horse Rider";
    public bool IsOlimpic() => true;
    public int NumberOfLegsToJump() => 4;
}


class Whales : Mammals
{
    public Whales(string name) : base(name) { }

    public void Swim() => Console.WriteLine("I can swim");
}

class Human : Mammals, ITerrestialMammals, IJump
{

    public Human(string name) : base(name)
    {

    }
    public override void Think() => Console.WriteLine("Advance thinking");
    public int NumberExtremitiesForMovement() => 2;
    public int NumberOfLegsToJump() => 2;

}

class Gorilla : Mammals, ITerrestialMammals, IJump
{

    public Gorilla(string name) : base(name)
    {

    }

    public void ClimbTrees() => Console.WriteLine("I can climb trees");
    public override void Think() => Console.WriteLine("Medium thinking");
    public int NumberExtremitiesForMovement() => 4;
    public int NumberOfLegsToJump() => 2;
}
