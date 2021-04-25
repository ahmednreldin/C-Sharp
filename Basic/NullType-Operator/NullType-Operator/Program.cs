using System;

namespace NullType_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable types in c#

            // C# types are divided into 2 broad categories
            // Value types - int,float,double,struct,enum..etc
            // Reference types - interface,Class,Delegates,arrays etc

            // by defual value types are non nullable 

            int i = 0; // work 
                       //int j = null; // error non-nuallable => value type 

            string Name = null; // work => cuz string class type [ Reference type ] can setting to null
                                // to make them nullable use question mark ? 
            int? j = null;
            Console.WriteLine("J Value Nulll => {0}", j);

            //Example

            bool? AreYouMajor = null; //add question mark cuz it's value type

            if (AreYouMajor == true)
            {
                Console.WriteLine("user is major");
            }
            else if (AreYouMajor == false) // value propery return value
                Console.WriteLine("user is major");
            else
                Console.WriteLine("user dident answer the question ");

            // Null Coalescing operator using double question mark[ ?? ]

            // Example 
            int? ticktOnSale = null;
            int avaliableTickt;

            if (ticktOnSale == null) avaliableTickt = 0;
            // else avaliableTickt = ticktOnSale; // => return error solve by -cast(int)ticktOnSale or - .value property 
            else avaliableTickt = ticktOnSale.Value;

            Console.WriteLine("Avaliable Ticket {0}", avaliableTickt);

            // best practice using double question mark ??

            avaliableTickt = ticktOnSale ?? 0; // if ticktOnSale == null will assign zero to avalible ticker - else put ticketOnSale inside avaliable

            Console.WriteLine("Avaliable ticket using ?? {0}", avaliableTickt);

        }
    }
}
