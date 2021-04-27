using System;
/*
        Abstract Classes V.S interfaces 
  = Abstract classes = 
- can have implementation for some of its members(Method) 
- can have fields 
- Can inheirt from antother abstract class or interface
- can inheirt from multiple inheirt from multiple interfaces at the same time 
- cannot inheirt from multiple classes at the same time 
- Members can have access modifers 
  = Interfaces = 
- can't have implementation for any of it's member 
- cannot have fields 
- an interface can inherit form another interface only and cannot inheirt from an abstract class
- cannot have access modifers [ cuz its by defualt a bais class ]
 */

//- can have implementation for some of its members(Method) 
/*abstract class Student{
    int j; 
    public void Print()
    {
        Console.WriteLine("Print");
    }
}*/
//- can't have implementation for any of it's member 
interface IStudent
{
//- cannot have fields 
    int j; 
    public void Print()
    {
        Console.WriteLine("Print");
    }
}

    class Program : IStudent
    {
        static void Main(string[] args)
        {
        Program p = new Program();
           
        }
    }
