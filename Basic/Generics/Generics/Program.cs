using System;
// Generics is similar to Templates in c++
// allow us to design class&method decoupling from the data types 
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreEqual<int>(4, 4));
            Console.WriteLine(AreEqual<string>("a", "A"));
            
        }

        // using boxing&unboxing ( object )  value type => reference type 
        // disAdvantage isNot A Type safe mean can pass AreEqual(1,"2") strongly typed property lose
        // performance intensive due to boxing and unboxing   
        public static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }
        // using Generic <T> 
        public static bool AreEqual<T>(T value1,T value2)
        {
            return value1.Equals(value2);
        }
    }
}

// you can make class Generic
class Numbers<T> { };