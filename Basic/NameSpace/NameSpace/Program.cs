using System;

// NameSpace is away to organize code , and avoid clashes ()
    class Program
    {
        static void Main(string[] args)
        {
        // invoke Print method from TeamA,B
        ProjectA.TeamA.ClassA.Print();
        ProjectA.TeamB.ClassB.Print();
        }
    }


// The project can contain many NameSpace 

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
        class ClassB
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }

}