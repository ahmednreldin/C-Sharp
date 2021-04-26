using System;

// use directive to decrease name
using ProjectA.TeamA;
using ProjectA.TeamB;

// using alies to avoid doublicated 
using TA = ProjectA.TeamA;
using TB = ProjectA.TeamB;

// NameSpace is away to organize code , and avoid clashes (akn ambiguous)
class Program
    {
        static void Main(string[] args)
        {
        // invoke Print method from TeamA,B
        ProjectA.TeamA.ClassA.Print();
        ProjectA.TeamB.ClassA.Print();
        // After using directive 
        ClassA.Print();
        ClassA.Print();
        // this will arise problem cuz both name space have same name method
        // can achive using alies 
        TA.ClassA.Print();
        TB.ClassA.Print();

    }
    }


// The project can contain many NameSpace 

// NameSpace can be nested in 2 ways 

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }

}
namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }

}

// method 2 [ instead of define nested namespace you can use dot notation .
// this equaivlent to the one above 
namespace ProjectA.TeamB
{
   
        class ClassB
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }

}