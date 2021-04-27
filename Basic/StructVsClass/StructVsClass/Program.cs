using System;

/* Class V.s Structs 
 * 
 * A Struct is 
 * a value type
 * stored in stack
 * value type hod their value in memory where they are declared
 * value type are destoryed immediately after the scope is lost 
 * when copy struct to another they will have different references in memory  
 * cannot have destructors
 * cannot have explicit parameter less constructor Employee()
 * cannot inherit from another class or struct (called sealed )
 * can inheriant from interface 

 * A class is
 * a reference type 
 * stored in heap 
 * reference type hold a refrence to an object in memory
 * refrence type variable is destoryed after the scope is lost , the object is later destroyed by garbage collector
 * when copy class to another will have same reference which mean change in one will effect on another
 * class can have destructors  
 */


namespace StructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
