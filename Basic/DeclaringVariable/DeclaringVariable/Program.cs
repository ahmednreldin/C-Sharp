using System;


    class Program
    {
        static void Main(string[] args)
        {
        // Declaring Variable 
            int number;
        //Console.WriteLine(number); // return error cuz variable unassigned
        // Note that C# Case senestive  Number != number 
        int Number = 12345;
        Console.WriteLine(Number);

        // constant variable 
        //const float pi;  // cannot define constant w/o setting it's value 
        //const float pi = 14.5; // return error cuz compiler automatically convert to duble - must but suffix f   
        const float pi = 3.14f; // 

        // identifiers [ variable name ] 
        // - cannot start with a number 
        //int 1num =   232; // Doesnt  compile  
        // - cannot include white space 
        // int num one = 123; // dosent compule

        // cannot be a reserved word e.g int,float,double
        // int int = 456;  
        //  if you are desperate to use a word that coincidentally clashes with one of the C# keywords you can perfect that with the add sign @
        int @int = 1235;
        Console.WriteLine(@int);

        // Naming conversion used in  c#
        // for local variable [ camel case ] 
        int numberOne = 1;
        // for constant variable [ Pascal Case ]
        const int MaxNumber = 9999;
    }
}

