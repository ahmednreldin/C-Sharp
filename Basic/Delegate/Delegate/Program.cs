using System;
using System.Collections.Generic;
/* 
A Delgate is pointer to a function  [ similar to callBack Function ]

* A Delagate benefit is reusabliliy and extendability of code 

" A Delgate is a type safe function pointer , that is it's holds a reference(pointer) to a function

type safe mean signature for delegate == to signature for the function 

- A Delegate is similar to a class => you can create an instance of it
and when you do so , you pass in the function name as parameter to the delegate constructor 
and its to the function the delegate will point to 
Tipl : Delegates syntax very similar to a method with a delegate keyword 

*/
// Define Delegate 
//Tipl : Delegates syntax very similar to a method with a delegate keyword 
public delegate void HelloFunctionDelegate(string msg);

    class Program
    {
        static void Main(string[] args)
        {
        //- A Delegate is similar to a class => you can create an instance of it

        /* HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
         del("Hello From Delegate");*/

        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee { ID = 101, Name = "Ahmed", Salary = 50000, Experience = 5 });
        empList.Add(new Employee { ID = 121, Name = "Mohamed", Salary = 2000, Experience = 2});
        empList.Add(new Employee { ID = 121, Name = "Hosam", Salary = 4000, Experience = 3});

        IsPromotable isPromotable = new IsPromotable(Promote);
        Employee.PromoteEmployee(empList, isPromotable);

        // or you can use exeprsion 
        Employee.PromoteEmployee(empList, Emp => Emp.Experience >= 5);


   }
    public static bool Promote(Employee em)
    {
        if (em.Experience >= 5) return true;
        else return false;
    }
    public static void Hello(string message)
    {
        Console.WriteLine(message);
    }
   }

// define delegate 
 delegate bool IsPromotable(Employee emp);
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList,IsPromotable IsEligiableToPromote)
    {
        foreach(Employee e in employeeList)
        {
            if (IsEligiableToPromote(e))
            {
                Console.WriteLine("Employee {0} is promoted", e.Name);
            }
        }
    } 
}

