using System;

/* 
        Inheritance 
    - one of praimary paillars of oop
    - allows code reuse
    - code reuse can reduce time(for testing & writing dublicate code ) and erros 
  
    == Note ==

- c# supports only single class inheritance 
- c# supports multiple inferface inhertitance 
- Parant(base) classes are autmoatically instantiated before child(derived classes 
- Parent Class constructor executes before child class constructor 
 
 */
class Employee
{
    public string fname;
    public string lname;
    public string email;

    public void print()
    {
        Console.WriteLine("Employee Name {0} \nEmployee Email {1}", fname+lname, email);
    }
}

class FullTimeEmployee : Employee
{
    float yearlySalary;
}


class PartTimeEmployee : Employee
{
    float hourlyRate;
}

//-c# supports only single class inheritance 

class A { }

//class B : A, Employee { }; // class B cannot have multiple base(parant) classes

//- c# supports multiple inferface inhertitance [ Multiple level class inheritance ] have same parant 
// this mean class C inherant from FullTimeEmployee and FTE inherant from Employee 
class C : FullTimeEmployee { };



//-Parent Class constructor executes before child class constructor
// you can avoid this using base keyword 

class Parant {
     public Parant()
    {
        Console.WriteLine("Parant class Constructor Called");
    } 
    public Parant(string Message)
    {
        Console.WriteLine(Message);
    }


};

// base force the constructor used instead of called less paramerers consturctor
class Child : Parant
{
    public Child() : base("Child class controlling ")
    {
        Console.WriteLine("Child class Constructor Called ");
    }
}

    class Program
    {
        static void Main(string[] args)
        {
        Employee lead = new Employee();
        lead.fname = "Ahmed";
        lead.lname = "Nour";
        lead.email = "ahmednr.dev@gmail.com";
        lead.print();

        FullTimeEmployee fte = new FullTimeEmployee();
        fte.fname = " Mohamed ";
        fte.lname = " Nour ";
        fte.email = "blahblah@blab.co";
        fte.print();

        // child 
        Child ch1 = new Child();
        }
    }
