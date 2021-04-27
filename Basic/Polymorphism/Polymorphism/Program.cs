using System;

/*
                 Polymorphism is one of the primary pillars of oop
    - allows you to invoke drived class method through a base class refernce during runtime
    - in the base class the method is declared virtual , and the drived class we override the same method 
    - the firtual keyword indicates , the method can be overriden in any drived class 
 */

 class Employee {

    public string fname, lname;

    public virtual void print()
    {
        Console.WriteLine("Parent Employee ");
    }
}
class FullTimeEmployee :Employee {

    public override void print()
    {
        Console.WriteLine("Full Time Employee "); 
    }
}
class PartTimeEmployee : Employee {
    public override void print()
    {
        Console.WriteLine("PartTime Employee ");
    }
}
class TemporaryTimeEmployee : Employee {
    public override void print()
    {
        Console.WriteLine("Temporary Time Employee ");
    }
}


    class Program
    {

    public static void Main(string[] args)
    { 

    Employee [] employees = new Employee[4];

    employees[0] = new Employee();
    employees[1] = new PartTimeEmployee();
    employees[2] = new FullTimeEmployee();
    employees[3] = new TemporaryTimeEmployee();
    
        foreach(Employee c in employees)
        {
            c.print();   
        }
    }
}
