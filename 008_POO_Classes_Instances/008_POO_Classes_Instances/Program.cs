Circles circleOne;   //CIRCLE'S OBJECT VARIABLE DEFINITION 
circleOne = new Circles();  //CIRCLE'S OBJECT INITIALIZATION, CLASS INSTANCE

Circles circleTwo = new Circles();

Console.WriteLine(circleOne.AreaCalc(1));
Console.WriteLine(circleTwo.AreaCalc(2));

class Circles
{

    // CLASS METHOD: WHAT THE OBJECT CAN DO?
    public double AreaCalc(double ratio) => _PI * Math.Pow(ratio, 2);
    
    //CIRCLE'S PROPERTY! -> CLASS CAMP!
    private const double _PI = Math.PI;        
   
}