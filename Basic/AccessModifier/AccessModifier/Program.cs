using System;
/*
            Types v.s Type Members 
        Customer is the type 
        _id => Fields , Properties , Methods are Type Members 
        
    => Class , struct , enums , interfaces ,delegates are called Type
    => Fields , Properties , Constructros , Methods ..etc that reside in a type called Type Members 

C# Access modifier [ 5 ]

1 -Private => only with in the containing class
2- Protected => with the containing types(class,enum..etc) , and the types derived from the containing type
3- internal => anyWhere with in the containing assembly 
4- Protected Internal => any where with in the conaining assembly and from withn a drived class in any another assembly 
5 -public => any where , no restricitons 

Type Members => can have all access modifiers [5] 
Types => can only have 2 [ internal , public ] 
 
 */

class Customer
{
    #region Fields
    private int _id;
    private string _name;
    #endregion

    #region Properties
    public string Name { get; set; }
    public int ID { get; set; }
    #endregion

    #region Method
    public void Print()
    {
        Console.WriteLine(Name + ID);
    }
    #endregion  



}
namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
