using System;
using System.Reflection;
/*
Type => get metaData 

Reflection e.g PropertyInfo[] ,MethodInfo[]
ex of reflection => Property GU in Windows Form
 
*/

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("Reflection.Customer");
            Console.WriteLine($"Full Name {T.FullName}");
            Console.WriteLine($"Name {T.Name}");
            Console.WriteLine($"Assembly {T.Assembly}");
            Console.WriteLine($"Namespace {T.Namespace}");
            Console.WriteLine();

            // Properties Reflection 
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo p in properties)
            {
                Console.WriteLine(p.PropertyType.Name + " " + p.Name);
            }
            // Method Reflection 
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo m in methods)
            {
                Console.WriteLine(m.ReturnType.Name + " " + m.Name);
            }


        }
    }

    class Customer {
        public int ID { get; set; }
        public string Name { get; set; }

        Customer(int id,string name)
        {
            ID = id;
            Name = name;
        }
        Customer() { }

        public void Print()
        {
            Console.WriteLine($"customer name {Name} ID {ID}");
        }
    }
}
