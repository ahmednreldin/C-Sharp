using System;
/*
        Multiple class inheritance problem [ Diamond Problem ]
           => note c# dosent support multiple class inhertiance 
        ------
        class A
        -------
        -       -
    ClassB     Class C
        -        -
          ClassD
 
 1 - Class B and Class C Inheirt from Class A.
 2 - Class D inheirts from both C & D 
 3 - if a method in D calls a method that deifne in A 
(and doesnt override the metohd),and B,C have overriden that method differently 
then from which class does it inheirt B,or C

    Solve Usign interfaces
 */
         /* Problem 
class A { 
    public virtual void Print()
    {
        Console.WriteLine("Class A implementation");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("Class B implementation");
    }
}

class C : A
{
    public override void Print()
    {
        Console.WriteLine("Class C implementation");
    }
}

class D : B,C { } 

*/

interface IA
{
    void AMethod();
}
class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A Method");
    }
}

interface IB
{
    void BMethod();
}

class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B Method");
    }
}

class AB : IA, IB
{
    A a = new A();
    B b = new B();

    public void AMethod()
    {
        a.AMethod();
    }

    public void BMethod()
    {
        b.BMethod();   
    }
}
class Program
    {
        static void Main(string[] args)
        {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();

        }
    }
