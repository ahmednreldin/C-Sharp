using System;
/*
        use the new keyword to hide a base class member 

        == Different way to invoke a hidden base(parent) class member form derived(child) class
  
    1- Use base keyword()
    2- cast child type to parent type and invoke hidden member 
    3- ParentClass PC = new ChildClass(); PC.HiddenMethod()
 */

class Employee {
    public string fname, lname;

    public void Print()
    {
        Console.WriteLine(fname + lname);
    }
}
class FullTimeEmployee : Employee{

    /// <summary>
    /// Compilation error 
    /// use new keyword if hidden was intended 
    /// </summary>
    /*public void Print()
    {
        Console.WriteLine(fname + lname);
    }*/


    /*public new void Print()
    {
        Console.WriteLine(fname + lname + "Full Time Employee");
    }*/

    // Base method to can invoke hidden method 
    /* public new void Print()
     {
         base.Print(); 
         Console.WriteLine(fname + lname + "Full Time Employee"); // execute both function if we didnt comment this 
     }
 */

    // cast type method
    public new void Print()
    {
        Console.WriteLine(fname + lname + "Full Time Employee");
    }
}
class PartTimeEmployee { }
class Program
    {
        static void Main(string[] args)
        {
        // invoke hidden method
        FullTimeEmployee FTM = new FullTimeEmployee();
        FTM.fname = "Ahmad";
        FTM.lname = "Nour";
        FTM.Print();

        // Base method 
        //FTM.Print();

        // cast method
        ((Employee)FTM).Print();

        // Pointing to base reference 
        Employee FTMTB = new FullTimeEmployee();
        // in this case will invoke bais class and the method inside it 
        // this consider Polymorphism concept  object(bais reference variable ) pointing to drived(child) class 
        // FTMB of type employee poining to adderss from type FTE
        FTMTB.fname = "Ahmad";
        FTMTB.lname = "Nour";
        FTMTB.Print();

    }
}
