using System;


    class Program
    {
        static void Main(string[] args)
        {
        // The void keyword represents the absence of a type.
        // You use it as the return type of a method that doesn't return a value.
        //  void x; // dosent compile 

        //  Primitive Types // 


        // integral numbers
        //  c# types 
        byte xSharp = 255; // byte 2^8-1 = 0-255 Maxvalue 255 min 0 
        //byte x = 256; // return error 
        Console.WriteLine("Byte Value {0}", xSharp);
        // .NET types
        Byte xNet = 255;
        Console.WriteLine("Byte Value {0}",xNet);

        int a = 123; // c#
        System.Int32 b = 123; // .NET  


        // Notes
        // • C# keywords are always lowercase 
        // • .NET keywords are always StartWith Uppercase

        /*-each of these C# keywords or C sharp types maps to a type in .NET
        so these types are part of the.net framework and when you compile your application the compiler internally would translate the C# keyword you   
        use here two equivalent.NET type*/

        // bool

        bool x = false; // only accept true of false setting 
        bool y = default;  // defualt keyword intilize variable with default value [ false ] 
        Console.WriteLine(x);
        Console.WriteLine(y);

        // RealNumber double float decimal
        /* there is something tricky about real numbers in 
         * for real numbers float ,double and decimal I've highlighted
         * double the default data type used by a C# compiler 
         * when you're using real numbers so if you want to declare 
         * a float you need to explicitly tell the compiler to
         * treat the number you have as a float 
         * here is an example I've declared a float  
         */

       // float fvalue = 145.5;  // return error  
        float fvalue = 145.5f;  //  

        // Decimal the bigger value in c#  16Bytes  16*8bit = 2^128 Byte  

        Console.WriteLine("Decimal MaxValue {0} MinValue{1}",decimal.MaxValue,decimal.MinValue);

        // var 
        var autoNum = 12345;
        var autoNumD = 123.5; // automatically convert to double / set Suffix if you want float F , deciaml M



        /*    Built -in types(C# reference)
    From < https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types> 
        */

    }
}
