using System;

class Circle
{
    // static member 
    public static float _pi;

    // insatnce member 
    int _Redius;

    // static Constructor first thing called when class used 
    static Circle()
    {
        Console.WriteLine("Static Constructor called");
        Circle._pi = 3.145f;
    }

    
    // instance members
    public Circle(int Redius)
    {
        Console.WriteLine("instance Constructor Called");
        this._Redius = Redius;
    }

    public float calculateArea()
    {   // note you can't call _pi using this cuz this for instance 
        return Circle._pi * this._Redius * this._Redius;
    }

}
  class Program
    {
        static void Main(string[] args)
        {

        Circle c1 = new Circle(5);
        Console.WriteLine(c1.calculateArea());
        Circle c2 = new Circle(8);
        Console.WriteLine(c2.calculateArea());

          var piValue = Circle._pi; // static constructor will called first 
        }
    }

