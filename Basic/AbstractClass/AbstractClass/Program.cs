using System;
/*
        The abstract keyword is used to create abstract classes 
    - An Abstract class 
    => is incomplete class and hance cannot be instantiated 
    => can only be used as base class (parent class )
    => cannot be sealed ( closed inheritance )
    => may contain abstract members( Methods,peoperties,indexers,and events) , but not mandatory
    => A Non-abstract class derived from an abstract class must provide implementations for all inherited abstract members
    => if a class inherits an abstract class there are 2 options avaliable for that class 
1- provide implementation for all the abstract members inherited from the base abstract class
2- if the class does not wish to provide implementation for all the abstract members inherited form the abstract class 
then the class has to be marked as abstract 
    
 */
    abstract class Emplyoee
    {
    //=> may contain abstract members( Methods,peoperties,indexers,and events) , but not mandatory
        abstract public void Print();
        public void Salary()
    {
        Console.WriteLine("Salary for employee");
    }
    }
//=> A Non-abstract class derived from an abstract class must provide implementations for all inherited abstract members

class PartTimeEmployee : Emplyoee
{
    public override void Print()
    { // implementation 
    }
}

//=> cannot be sealed or static ( closed inheritance )
//abstract sealed class Student { }
class Program : Emplyoee
{
    static void Main(string[] args)
        {
       //=> is incomplete class and hance cannot be instantiated
        Program p1 = new Program();
        p1.Print();
        }
public override void Print()
    {
        throw new NotImplementedException();
    }
}
