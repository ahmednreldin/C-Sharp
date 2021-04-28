using System;
/*
 Boxing is the process of converting a value type to 
    the Refernce type 
    object or to any interface type implemented by this value type
    Unboxing extracts the value type from the object

Performance
In relation to simple assignments, 
boxing and unboxing are computationally expensive processes
 */
class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
        // The following line boxes i.
            object o = i; // boxing

        //  The object o can then be unboxed and assigned to integer variable i: C#

         o = 123;
         i = (int)o;  // unboxing

    }
    }
