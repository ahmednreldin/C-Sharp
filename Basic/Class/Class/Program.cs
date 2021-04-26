using System;

/// <summary>
///                 == Class == 
///  Class used if you want to create custom type 
///  A Class consists of data[represents by it's fields (property)] and behavior [ represented by it's method ]
///                 == Constructor ==  
/// - intialize class fields 
/// - A Class constructor is automatically called when an instance of a class is created
/// - Constructors dont have return values 
/// - always have the same name as the class
/// - Constructors are not mandatory [ if we dont provide a constructor a default parameter less constructor is automatically provided ]
/// - Constructors can be overloaded by the number and type of parameters 
///                 ==  Destructors == 
/// - Have the same name as the class with tail symbol ~ in front of them
/// - they dont take any parameters and dont return a value 
/// - Destructors are places where you could put code to release any resources your class was holding during it's lifetime 
/// they are normally called when the c# garbage collector decides to clean your object 
/// from memory 

/// </summary>

class Customer
{
    // fields 
    string _fname;
    string _lname;

    // Constructor
    public Customer(string firstName,string lastName)
    {
        this._fname = firstName;
        this._lname = lastName;
    }
    // overloading constructor 
    public Customer() : this("first name not provide", "last Name not provide") { }

    // method
    public void print()
    {
        Console.WriteLine("Full Name {0}", this._fname + " " + this._lname);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer();
        
        Customer c2 = new Customer("Jhon","doe");

        c1.print();
        c2.print();
    }
}
