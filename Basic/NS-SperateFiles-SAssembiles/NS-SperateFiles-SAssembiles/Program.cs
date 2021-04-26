using System;

using PATA = ProjectA.TeamA.ClassA;
using PATB = ProjectA.TeamB.ClassB;
    class Program
    {
        static void Main(string[] args)
        {
        // From Seprate File 
        ProjectA.TeamA.ClassA.Print();

        // From Seprate Assembly 
        ProjectA.TeamB.ClassB.Print();

        // after using [ alies and directive ] 
        PATA.Print();
        PATB.Print();
        }
    }
