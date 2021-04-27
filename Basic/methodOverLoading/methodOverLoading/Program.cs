using System;
/*
        Method[function] overloading 
    - Allows a class to have multiple methods with the same name but 
    => with a Different signature [ The number of parameters, type(int,float..etc),kind (Value,Ref or Out) of parameters
 
    signature of a method consists of the name of the method and the type , kind of type ( ref,out) ,number of farameters

 */

    class Program
    {
        static void Main(string[] args)
        {
                 Add(4,5);

         }
    public static void Add(int fn, int ln)
    {
        Console.WriteLine("Result {0}", fn + ln);
    }

        // OVerloading Method 
    // Number of parameters 
    public static void Add(int fn, int ln,int tn)
    {
        Console.WriteLine("Result {0}", fn + ln);
    }
    // Type of parm
    public static void Add(float fn, float ln)
    {
        Console.WriteLine("Result {0}", fn + ln);
    }

    // kind of parm
    public static void Add(float fn, out float ln)
    {
        ln = fn;
        Console.WriteLine("Result {0}", fn + ln);
    }

}
