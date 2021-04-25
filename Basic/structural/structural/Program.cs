//using System; // NameSpace Declration  indicate that you're using System namespace 

//A namespace is used to organize your code and is collection of classes, interfaces, structs, enums and delegates.

class Program
    {
    // Main method is the entry point into your application 
    static void Main(string[] args)
        {
            // write to console 
           Console.WriteLine("Hello World!"); //  Console class in namespace system 
            // if you omit namespace declartion 
            // you write full qualified name of the Console class
            System.Console.WriteLine("Hello World!"); 
        }

    }
