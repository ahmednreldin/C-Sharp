using System;

    class Program
    {
        static void Main(string[] args)
        {
        /* Example int => float 
        int x = 100;
        float y = x;
        Console.WriteLine(y);*/

        /* Example float => int 
        float pi = 3.1456f;
        int takePI = pi; */ //compilation error 

        // Explicit Conversion 
        // == Method 1 == cast ()
        /*float pi = 3.1456f;
        int takePI = (int)pi; // note will lose fraction part
        Console.WriteLine(takePI);*/


        // Problem of cast => if overflow occur 
        float myLargeNumber = 45454878755215.22f;
        int takeLargeNumber = (int)myLargeNumber; // return minvalue for integer 
        /*Console.WriteLine(takeLargeNumber);*/

        // == Method 2 == Convert return exeption if overflow occur 
        /*  takeLargeNumber = Convert.ToInt32(myLargeNumber); // return Exception  
          Console.WriteLine(takeLargeNumber);*/

        // If number is string format 
        string num = "123";
        // == method 1 == Parse 
        int numParse = int.Parse(num);
       /* Console.WriteLine(numParse);*/

        // Drawback of this method if string contain letter  
        num = "123ggg"; //string contain letters
        /*numParse = int.Parse(num); // return exeption 
        Console.WriteLine(numParse);*/

        // == Method 2 == tryParse => solve problem of exception  return bool indicating if conversion done or fail
        int result=0;
        bool isConversionDone = int.TryParse(num, out result); // return type of bool  ,, setting new conversion in => out variable

        if (isConversionDone) Console.WriteLine("Conversion Done");
        if (!isConversionDone) Console.WriteLine("Conversion Fail");
                       
        // Use Parse if sure the value will be valid 
       
    }
    }
